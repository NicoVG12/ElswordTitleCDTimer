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
            _config.UserActionKeys.AwakeningKey = (short)StringToKeys(txtAwkKey.Text);
            _config.UserActionKeys.OnionKey = (short)StringToKeys(txtOnion.Text);
            _config.UserActionKeys.OnionKeyAlt = (short)StringToKeys(txtOnionAlt.Text);
            _config.UserActionKeys.TitleSwitchKey = (short)StringToKeys(txtTitleSwitch.Text);

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
    }
}
