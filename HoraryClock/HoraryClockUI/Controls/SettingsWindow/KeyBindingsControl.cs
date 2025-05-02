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
    public partial class KeyBindingsControl : UserControl, ILanguageSetter
    {
        private string _cannotBoundSameKeyToMultipleActionsMessage;
        private MainForm _mainForm;
        private Config _config = Config.Instance();
        public KeyBindingsControl(MainForm mainForm)
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

            txt135Key.Text = converter.ConvertToString((Keys)_config.KeyBindings.Key13_5);
            txt156Key.Text = converter.ConvertToString((Keys)_config.KeyBindings.Key15_6);
            txt175Key.Text = converter.ConvertToString((Keys)_config.KeyBindings.Key17_5);
            txtOrderKey.Text = converter.ConvertToString((Keys)_config.KeyBindings.KeyOrder);
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
            if (KeysRepeated())
            {
                lblMessage.Visible = true;

                await Task.Delay(3000);
                lblMessage.Visible = false;

            }
            else
            {

                _config.KeyBindings.Key13_5 = (short)StringToKeys(txt135Key.Text);
                _config.KeyBindings.Key15_6 = (short)StringToKeys(txt156Key.Text);
                _config.KeyBindings.Key17_5 = (short)StringToKeys(txt175Key.Text);
                _config.KeyBindings.KeyOrder = (short)StringToKeys(txtOrderKey.Text);

                _config.Save();
                _mainForm.LoadConfig();
                _mainForm.LoadKeyBindings();
 
            }

        }

        private bool KeysRepeated()
        {
            bool repeated = false;

            repeated |= txt135Key.Text == txt156Key.Text;
            repeated |= txt135Key.Text == txt175Key.Text;
            repeated |= txt135Key.Text == txtOrderKey.Text;
            repeated |= txt156Key.Text == txt175Key.Text;
            repeated |= txt156Key.Text == txtOrderKey.Text;
            repeated |= txt175Key.Text == txtOrderKey.Text;

            //TODO: Check Other Config Keys

            return repeated;
        }

        private void SetText(TextBox textBox, KeyEventArgs e)
        {
            string newKey = e.KeyCode.ToString();
            newKey = StringToKeys(newKey).ToString();
            textBox.Text = newKey;
        }

        private void txtStartKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt135Key.Text = "";
        }

        private void txtStartKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txt135Key, e);
        }

        private void txtPauseKey_KeyDown(object sender, KeyEventArgs e)
        {
            txt156Key.Text = "";
        }

        private void txtPauseKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt156Key.Text = "";
        }

        private void txtPauseKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txt156Key, e);
        }

        private void txtResetKey_KeyDown(object sender, KeyEventArgs e)
        {
            txt175Key.Text = "";
        }

        private void txtResetKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt175Key.Text = "";
        }

        private void txtResetKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txt175Key, e);
        }

        private void txtStartKey_KeyDown(object sender, KeyEventArgs e)
        {
            txt135Key.Text = "";
        }

        public void SetLanguage(LanguageData languageData)
        {
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

        private void txtOrderKey_KeyDown(object sender, KeyEventArgs e)
        {
            txtOrderKey.Text = "";
        }

        private void txtOrderKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtOrderKey.Text = "";
        }

        private void txtOrderKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txtOrderKey, e);
        }
    }
}
