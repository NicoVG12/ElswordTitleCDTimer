using HoraryClock;
using Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitleTimerUI.Controls.SettingsWindow
{
    public partial class ActionKeysControl : UserControl, ILanguageSetter
    {
        private string _cannotBoundSameKeyToMultipleActionsMessage;
        private MainForm _mainForm;
        private Config _config = Config.Instance();

        private Keys _awk;
        private Keys _onion;
        private Keys _onionAlt;
        private Keys _titleSwitch;

        public ActionKeysControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            InitializeHoveringIcons();
            LoadConfig();
            lblMessage.Visible = false;
            Refresh();
        }
        private void InitializeHoveringIcons()
        {
            lblSave.MouseEnter += OnMouseEnter;
            lblSave.MouseLeave += OnMouseLeave;
        }

        private void LoadConfig()
        {
            KeysConverter converter = new KeysConverter();

            txtAwkKey.Text = converter.ConvertToString((Keys)_config.UserActionKeys.AwakeningKey);
            txtOnion.Text = converter.ConvertToString((Keys)_config.UserActionKeys.OnionKey);
            txtOnionAlt.Text = converter.ConvertToString((Keys)_config.UserActionKeys.OnionKeyAlt);
            txtTitleSwitch.Text = converter.ConvertToString((Keys)_config.UserActionKeys.TitleSwitchKey);

            _awk = (Keys)_config.UserActionKeys.AwakeningKey;
            _onion = (Keys)_config.UserActionKeys.OnionKey;
            _onionAlt = (Keys)_config.UserActionKeys.OnionKeyAlt;
            _titleSwitch = (Keys)_config.UserActionKeys.TitleSwitchKey;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            lblSave.Image = Properties.Resources.btnSaveHover1;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            lblSave.Image = Properties.Resources.btnSave;
        }

        private async void lblSave_Click(object sender, EventArgs e)
        {
            _config.UserActionKeys.AwakeningKey = (short)_awk;
            _config.UserActionKeys.OnionKey = (short)_onion;
            _config.UserActionKeys.OnionKeyAlt = (short)_onionAlt;
            _config.UserActionKeys.TitleSwitchKey = (short)_titleSwitch;

            _config.Save();
            _mainForm.LoadConfig();
            _mainForm.LoadKeyBindings();
        }

        private void SetText(TextBox textBox, KeyEventArgs e)
        {
            string newKey = e.KeyCode.ToString();
            newKey = StringToKeys(newKey).ToString();
            textBox.Text = newKey;
        }

        private void txtStartKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtAwkKey.Text = "";
        }

        private void txtStartKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txtAwkKey, e);
            _awk = e.KeyCode;
        }

        private void txtPauseKey_KeyDown(object sender, KeyEventArgs e)
        {
            txtOnionAlt.Text = "";
        }

        private void txtPauseKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtOnionAlt.Text = "";
        }

        private void txtPauseKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txtOnionAlt, e);
            _onionAlt = e.KeyCode;
        }

        private void txtResetKey_KeyDown(object sender, KeyEventArgs e)
        {
            txtTitleSwitch.Text = "";
        }

        private void txtResetKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTitleSwitch.Text = "";
        }

        private void txtResetKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txtTitleSwitch, e);
            _titleSwitch = e.KeyCode;
        }

        private void txtStartKey_KeyDown(object sender, KeyEventArgs e)
        {
            txtAwkKey.Text = "";
        }

        public void SetLanguage(LanguageData languageData)
        {
        }

        public Keys StringToKeys(string key)
        {
            if (Enum.TryParse<Keys>(key, out var result))
                return result;
            return Keys.F1;
        }

        private void txtOnion_KeyDown(object sender, KeyEventArgs e)
        {
            txtOnion.Text = "";
        }

        private void txtOnion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtOnion.Text = "";
        }

        private void txtOnion_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txtOnion, e);
            _onion = e.KeyCode;
        }
    }
}
