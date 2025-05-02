using Clock;
using HoraryClock;
using Language;
using Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TitleTimerUI.Controls
{
    public partial class MiniClockControl : UserControl, ILanguageSetter
    {
        private Keys Key13_5;
        private Keys Key15_6;
        private Keys Key17_5;
        private Keys KeyOrder;
        private Keys KeyPauseAll;
        private Keys KeyUnpauseAll;
        private Keys KeyResetAll;

        private short Enter = 0x0D;
        private short Escape = 0x1B;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        private MainForm _mainForm;
        private bool _isRunning;

        private Config _config = Config.Instance();

        private List<TitleTimer> _timers = new List<TitleTimer>();

        private int _refreshDelay = 33;
        public MiniClockControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            _config.Load();
            LoadKeyBindings();
            SetUpKeyBindings();
            AttachDelegates();
            InitializeTimers();


        }

        private void InitializeTimers()
        {
            ClockManager _175Manager = new ClockManager(60000);
            ClockManager _135Manager = new ClockManager(30000);
            ClockManager _156Manager = new ClockManager(25000);
            ClockManager OrderManager = new ClockManager(30000);

            TitleTimer _175Timer = new TitleTimer(lbl175, _175Manager, Properties.Resources.Title_175_CD1, Properties.Resources.Title_175);
            TitleTimer _135Timer = new TitleTimer(lbl135, _135Manager, Properties.Resources.Title_135_CD1, Properties.Resources.Title_135);
            TitleTimer _156Timer = new TitleTimer(lbl156, _156Manager, Properties.Resources.Title_156_CD1, Properties.Resources.Title_156);
            TitleTimer OrderTimer = new TitleTimer(lblOrder, OrderManager, Properties.Resources.Title_Order_CD, Properties.Resources.Title_Order);

            _timers.Add(_175Timer);
            _timers.Add(_156Timer);
            _timers.Add(_135Timer);
            _timers.Add(OrderTimer);
        }

        public async Task SetUpKeyBindings()
        {
            if (false)
            {
                while (true)
                {
                    if (GetAsyncKeyState((int)Key13_5) < 0)
                    {
                        StartTimer(_timers[TitleTimer.ID_135]);
                    }

                    if (GetAsyncKeyState((int)Key15_6) < 0)
                    {
                        StartTimer(_timers[TitleTimer.ID_156]);
                    }

                    if (GetAsyncKeyState((int)Key17_5) < 0)
                    {
                        StartTimer(_timers[TitleTimer.ID_175]);
                    }

                    if (GetAsyncKeyState((int)KeyOrder) < 0)
                    {
                        StartTimer(_timers[TitleTimer.ID_ORDER]);
                    }

                    if (GetAsyncKeyState((int)KeyPauseAll) < 0)
                    {
                        foreach (TitleTimer title in _timers)
                        {
                            title.Timer.Pause();
                        }
                    }

                    if (GetAsyncKeyState((int)KeyUnpauseAll) < 0)
                    {
                        foreach (TitleTimer title in _timers)
                        {
                            UnpauseTimer(title);
                        }
                    }

                    if (GetAsyncKeyState((int)KeyResetAll) < 0)
                    {
                        foreach (TitleTimer title in _timers)
                        {
                            title.Timer.Reset();
                            title.Label.Image = title.Image;
                        }
                    }

                    await Task.Delay(10);
                }
            }

            TitleStatus titleStatus = new TitleStatus();

            while (true)
            {
                if (((GetAsyncKeyState((int)_config.UserActionKeys.OnionKey) < 0) || (GetAsyncKeyState((int)_config.UserActionKeys.OnionKeyAlt) < 0) || (GetAsyncKeyState((int)_config.UserActionKeys.AwakeningKey) < 0)) && titleStatus.CurrentTitle == TitleScheme.AwkCDrTitle)
                {
                    StartTimer(_timers[TitleTimer.ID_135]);
                }

                bool pressedAnySkill = false;
                foreach (short key in _config.UserActionKeys.SkillKeys)
                {
                    {
                        pressedAnySkill |= (GetAsyncKeyState((int)key) < 0);
                    }

                    if (pressedAnySkill && titleStatus.CurrentTitle == TitleScheme.ResetSkillTitle)
                    {
                        StartTimer(_timers[TitleTimer.ID_156]);
                    }

                    if (((GetAsyncKeyState((int)_config.UserActionKeys.OnionKey) < 0) || (GetAsyncKeyState((int)_config.UserActionKeys.OnionKeyAlt) < 0) || (GetAsyncKeyState((int)_config.UserActionKeys.AwakeningKey) < 0)) && titleStatus.CurrentTitle == TitleScheme.AwkDmgTitle)
                    {
                        StartTimer(_timers[TitleTimer.ID_175]);
                    }

                    if (pressedAnySkill && titleStatus.CurrentTitle == TitleScheme.MainTitle)
                    {
                        StartTimer(_timers[TitleTimer.ID_ORDER]);
                    }

                    if (GetAsyncKeyState((int)KeyPauseAll) < 0)
                    {
                        foreach (TitleTimer title in _timers)
                        {
                            title.Timer.Pause();
                        }
                    }

                    if (GetAsyncKeyState((int)KeyUnpauseAll) < 0)
                    {
                        foreach (TitleTimer title in _timers)
                        {
                            UnpauseTimer(title);
                        }
                    }

                    if (GetAsyncKeyState((int)KeyResetAll) < 0)
                    {
                        foreach (TitleTimer title in _timers)
                        {
                            title.Timer.Reset();
                            title.Label.Image = title.Image;
                        }
                    }

                    if (GetAsyncKeyState(_config.UserActionKeys.TitleSwitchKey) < 0)
                    {
                        titleStatus.IsSwitchingTitle = true;
                    }

                    if (titleStatus.IsSwitchingTitle && GetAsyncKeyState(_config.UserActionKeys.TopTitleKey) < 0)
                    {
                        ChangeTitleAsync(TitleScheme.AwkDmgTitle, titleStatus);
                        titleStatus.IsSwitchingTitle = false;
                    }

                    if (titleStatus.IsSwitchingTitle && GetAsyncKeyState(_config.UserActionKeys.LeftTitleKey) < 0)
                    {
                        ChangeTitleAsync(TitleScheme.AwkCDrTitle, titleStatus);
                        titleStatus.IsSwitchingTitle = false;
                    }

                    if (titleStatus.IsSwitchingTitle && GetAsyncKeyState(_config.UserActionKeys.RightTitleKey) < 0)
                    {
                        ChangeTitleAsync(TitleScheme.MainTitle, titleStatus);
                        titleStatus.IsSwitchingTitle = false;
                    }

                    if (titleStatus.IsSwitchingTitle && GetAsyncKeyState(_config.UserActionKeys.BottomTitleKey) < 0)
                    {
                        ChangeTitleAsync(TitleScheme.ResetSkillTitle, titleStatus);
                        titleStatus.IsSwitchingTitle = false;
                    }

                    await Task.Delay(1);
                }
            }
        }

        private async Task ChangeTitleAsync(int titleId, TitleStatus titleStatus)
        {
            await Task.Delay(_config.TitleSwitchDelayMilliseconds);
            titleStatus.CurrentTitle = titleId;
        }

        void UnpauseTimer(TitleTimer title)
        {
            if (title.Timer.ElapsedTime > 0)
            {
                StartTimer(title);
            }
        }

        public void LoadConfig()
        {
            _mainForm.TopMost = _config.WindowAlwaysOnTop == Config.CHECKED;
            _mainForm.Opacity = 0.1 * (_config.WindowOpacity + 1);
        }

        public void LoadKeyBindings()
        {
            Key13_5 = (Keys)_config.KeyBindings.Key13_5;
            Key15_6 = (Keys)_config.KeyBindings.Key15_6;
            Key17_5 = (Keys)_config.KeyBindings.Key17_5;
            KeyOrder = (Keys)_config.KeyBindings.KeyOrder;
            KeyPauseAll = (Keys)_config.KeyBindings.KeyPauseAll;
            KeyUnpauseAll = (Keys)_config.KeyBindings.KeyUnpauseAll;
            KeyResetAll = (Keys)_config.KeyBindings.KeyResetAll;
        }

        private void lblMaximize_Click(object sender, EventArgs e)
        {
            bool isRunning = _isRunning;
            _isRunning = false;
        }

        private async void lblCloseWindow_Click(object sender, EventArgs e)
        {
            while (_mainForm.Opacity > 0)
            {
                _mainForm.Opacity -= .08;
                _mainForm.Refresh();
                Refresh();
            }
            _mainForm.Close();
        }

        private void lblBackground_Click(object sender, EventArgs e)
        {

        }

        private void lblBackground_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainForm.ReleaseCapture();
                MainForm.SendMessage(_mainForm.Handle, MainForm.WM_NCLBUTTONDOWN, MainForm.HT_CAPTION, 0);
            }
        }

        public void label1_Click(object sender, EventArgs e)
        {


        }

        internal void UpdateLabels(string remainingTimeMessage)
        {

        }

        internal void SetInitialLabel()
        {
        }

        internal async Task StartTimer(TitleTimer title)
        {
            if (!title.Timer.IsRunning)
            {
                title.Label.Image = title.CDImage;
                Task.Run(() => title.Timer.StartAsync());
                await (Task.Delay(15));
                while (title.Timer.IsRunning)
                {
                    title.Label.Text = String.Format("{0:0.0}", (title.Timer.TotalTime - title.Timer.ElapsedTime) / 1000);
                    await (Task.Delay(_refreshDelay));
                }

                if (title.Timer.ElapsedTime == 0)
                {
                    title.Label.Text = "";
                    title.Label.Image = title.Image;
                }
            }
        }




        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void SetLanguage(LanguageData languageData)
        {

        }

        private void lbl175_Click(object sender, EventArgs e)
        {
        }

        private void AttachDelegates()
        {

            lblCloseWindow.MouseEnter += OnMouseEnterClose;
            lblCloseWindow.MouseLeave += OnMouseLeaveClose;
            lblMaximize.MouseEnter += OnMouseEnterMaximize;
            lblMaximize.MouseLeave += OnMouseLeaveMaximize;

        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            lblCloseWindow.Image = Properties.Resources.btnMiniCloseHover;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            lblCloseWindow.Image = Properties.Resources.btnMiniClose;
        }

        private void OnMouseEnterMaximize(object sender, EventArgs e)
        {
            lblMaximize.Image = Properties.Resources.btnMaximizeHover;
        }

        private void OnMouseLeaveMaximize(object sender, EventArgs e)
        {
            lblMaximize.Image = Properties.Resources.btnMaximize;
        }

        private void lblMaximize_Click_1(object sender, EventArgs e)
        {
            _mainForm.Maximize("");
        }
    }
}
