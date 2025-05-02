using Clock;
using HoraryClock;
using TitleTimerUI.Controls;
using TitleTimerUI.Controls.MainWindow;
using TitleTimerUI.Controls.SettingsWindow;
using Language;
using System.Configuration;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TitleTimerUI
{

    public partial class MainForm : Form, ILanguageSetter
    {
        private Keys Key13_5;
        private Keys Key15_6;
        private Keys Key17_5;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int CONTROL_AMOUNT = 3;

        public const int CLOCK_ID = 0;
        public const int SETTINGS_ID = 1;
        public const int MINI_CLOCK_ID = 2;

        private Config _config = Config.Instance();
        private LanguageManager _languageManager = LanguageManager.Instance();
        private Control[] _controls = new Control[CONTROL_AMOUNT];
        private Control[] _controlsBeforeResize;
        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
            InitializeTitle();
            AttachDelegates();
            LoadConfig();
            LoadKeyBindings();
            ShowTab(CLOCK_ID);
            SetLanguage(_languageManager.GetLanguageData(_config.LanguageId));

            //Minimize("0");
            ShowTab(MainForm.SETTINGS_ID);
        }


        public void LoadConfig()
        {
            TopMost = _config.WindowAlwaysOnTop == Config.CHECKED;
            Opacity = 0.1 * (_config.WindowOpacity + 1);
        }

        public void LoadKeyBindings()
        {
            MiniClockControl timersControl = _controls[MINI_CLOCK_ID] as MiniClockControl;    
            timersControl.LoadKeyBindings();
        }

        private bool Minimized(int height)
        {
            return height == 104;
        }

        private void AttachDelegates()
        {
            lblCloseWindow.MouseEnter += OnMouseEnter;
            lblCloseWindow.MouseLeave += OnMouseLeave;

            lblMinimize.MouseEnter += OnMouseEnterMinimize;
            lblMinimize.MouseLeave += OnMouseLeaveMinimize;
        }

        private void InitializeControls()
        {
            _controls[CLOCK_ID] = new ClockControl(this);
            _controls[SETTINGS_ID] = new SettingsControl(this);
            _controls[MINI_CLOCK_ID] = new MiniClockControl(this);
        }

        private void InitializeTitle()
        {
            Text = "Title CD Timer v1.0";
            lblBackground.Text = Text;
            Icon = Properties.Resources.Title_175_Icon;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ShowTab(int tabId)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(_controls[tabId]);
            mainPanel.Refresh();
            Refresh();
        }

        private void lblWindowHover_Click(object sender, EventArgs e)
        {

        }

        private void lblWindowHover_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblBackground_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private async void lblCloseWindow_Click(object sender, EventArgs e)
        {
            while (Opacity > 0)
            {
                Opacity -= .08;
                Refresh();
            }
            Close();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            lblCloseWindow.Image = Properties.Resources.btnClose_hover;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            lblCloseWindow.Image = Properties.Resources.btnClose_normal;
        }

        private void OnMouseEnterMinimize(object sender, EventArgs e)
        {
            lblMinimize.Image = Properties.Resources.btnMinimizeHover;
        }

        private void OnMouseLeaveMinimize(object sender, EventArgs e)
        {
            lblMinimize.Image = Properties.Resources.btnMinimize;
        }

        public async void Minimize(string RemainingTimeMessage)
        {
            MiniClockControl MiniClockControl = _controls[MINI_CLOCK_ID] as MiniClockControl;
            MiniClockControl.UpdateLabels(RemainingTimeMessage);

            _controlsBeforeResize = new Control[Controls.Count];
            Controls.CopyTo(_controlsBeforeResize, 0);
            Controls.Clear();
            Controls.Add(_controls[MINI_CLOCK_ID]);
            Size = new Size(191, 104);
        }

        public async void Maximize(string RemainingTimeMessage)
        {
            ClockControl clockControl = _controls[CLOCK_ID] as ClockControl;
            Controls.Clear();
            foreach (Control c in _controlsBeforeResize)
            {
                Controls.Add(c);
            }

            Size = new Size(529, 332);
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            ClockControl clockControl = _controls[CLOCK_ID] as ClockControl;
            Minimize(clockControl.GetRemainingTime());
        }

        public Keys StringToKeys(string key)
        {
            switch (key)
            {
                case "F1": return Keys.F1;
                case "F2": return Keys.F2;
                case "F3": return Keys.F3;
                case "F4": return Keys.F4;
                case "F5": return Keys.F5;
                case "F6": return Keys.F6;
                case "F7": return Keys.F7;
                case "F8": return Keys.F8;
                case "F9": return Keys.F9;
                case "F10": return Keys.F10;
                case "F11": return Keys.F11;
                case "F12": return Keys.F12;
                default: return Keys.F1;
            }
        }

        public void SetLanguage(LanguageData languageData)
        {
            foreach (Control control in _controls)
            {
                ILanguageSetter controlLanguageSetter = control as ILanguageSetter;
                controlLanguageSetter.SetLanguage(languageData);
            }
        }
    }
}