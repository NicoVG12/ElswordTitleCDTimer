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
    public partial class CommonKeyBindingsControl : UserControl, ILanguageSetter
    {
        private string _cannotBoundSameKeyToMultipleActionsMessage;
        private MainForm _mainForm;
        private Config _config = Config.Instance();
        public CommonKeyBindingsControl(MainForm mainForm)
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

            txtResetAllKey.Text = converter.ConvertToString((Keys)_config.KeyBindings.KeyResetAll);
            txtUnpauseAllKey.Text = converter.ConvertToString((Keys)_config.KeyBindings.KeyUnpauseAll);
            txtPauseAllKey.Text = converter.ConvertToString((Keys)_config.KeyBindings.KeyPauseAll);
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
                _config.KeyBindings.KeyResetAll = (short)StringToKeys(txtResetAllKey.Text);
                _config.KeyBindings.KeyUnpauseAll = (short)StringToKeys(txtUnpauseAllKey.Text);
                _config.KeyBindings.KeyPauseAll = (short)StringToKeys(txtPauseAllKey.Text);

                _config.Save();
                _mainForm.LoadConfig();
                _mainForm.LoadKeyBindings();

            }

        }

        private bool KeysRepeated()
        {
            bool repeated = false;

            repeated |= txtResetAllKey.Text == txtUnpauseAllKey.Text;
            repeated |= txtResetAllKey.Text == txtPauseAllKey.Text;
            repeated |= txtUnpauseAllKey.Text == txtPauseAllKey.Text;

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
            txtResetAllKey.Text = "";
        }

        private void txtStartKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txtResetAllKey, e);
        }

        private void txtPauseKey_KeyDown(object sender, KeyEventArgs e)
        {
            txtUnpauseAllKey.Text = "";
        }

        private void txtPauseKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUnpauseAllKey.Text = "";
        }

        private void txtPauseKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txtUnpauseAllKey, e);
        }

        private void txtResetKey_KeyDown(object sender, KeyEventArgs e)
        {
            txtPauseAllKey.Text = "";
        }

        private void txtResetKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPauseAllKey.Text = "";
        }

        private void txtResetKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txtPauseAllKey, e);
        }

        private void txtStartKey_KeyDown(object sender, KeyEventArgs e)
        {
            txtResetAllKey.Text = "";
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

        private void lblUnpauseAllKeyDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
