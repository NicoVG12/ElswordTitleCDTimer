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
    public partial class TitleSettingsControl : UserControl, ILanguageSetter
    {
        private string _cannotBoundSameKeyToMultipleActionsMessage;
        private MainForm _mainForm;
        private Config _config = Config.Instance();
        private List<Image> _images = new List<Image>() { Properties.Resources.Title_Empty, Properties.Resources.Title_175, Properties.Resources.Title_Order, Properties.Resources.Title_135, Properties.Resources.Title_156 };
        private List<ComboBox> _combos;
        private List<String> _options = new List<string>() { "No Title", "Freed Shadow", "Order", "Twilight of Gods", "Night Parade" };

        private Keys _awk;
        private Keys _onion;
        private Keys _onionAlt;
        private Keys _titleSwitch;

        public TitleSettingsControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            InitializeHoveringIcons();
            lblMessage.Visible = false;
            Refresh();

            _combos = new List<ComboBox>()
            {
                cmbTop, cmbLeft, cmbRight, cmbBot
            };

            LoadConfig();
        }
        private void InitializeHoveringIcons()
        {
            lblSave.MouseEnter += OnMouseEnter;
            lblSave.MouseLeave += OnMouseLeave;
        }

        private void LoadConfig()
        {
            KeysConverter converter = new KeysConverter();

            foreach (String item in _options)
            {
                foreach (ComboBox comboBox in _combos)
                {
                    comboBox.Items.Add(item);
                }
            }

            cmbTop.SelectedIndex = _config.TitleScheme.TopTitle + 1;
            cmbLeft.SelectedIndex = _config.TitleScheme.LeftTitle + 1;
            cmbRight.SelectedIndex = _config.TitleScheme.RightTitle + 1;
            cmbBot.SelectedIndex = _config.TitleScheme.BottomTitle + 1;

            numDelay.Value = _config.TitleSwitchDelayMilliseconds;
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
            _config.TitleSwitchDelayMilliseconds = (int)numDelay.Value;

            _config.TitleScheme.TopTitle = cmbTop.SelectedIndex - 1;
            _config.TitleScheme.LeftTitle = cmbLeft.SelectedIndex - 1;
            _config.TitleScheme.RightTitle = cmbRight.SelectedIndex - 1;
            _config.TitleScheme.BottomTitle = cmbBot.SelectedIndex - 1;

            _config.Save();
            _mainForm.LoadConfig();
            _mainForm.LoadKeyBindings();
        }

        private void SetTitle(Label titleLabel, int newTitle)
        {
            titleLabel.Image = _images[newTitle];
        }


        public void SetLanguage(LanguageData languageData)
        {
        }

        private void lbl156Key_Click(object sender, EventArgs e)
        {

        }

        private void cmbTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTitle(lblTopTitle, cmbTop.SelectedIndex);
        }

        private void cmbLeft_SelectedValueChanged(object sender, EventArgs e)
        {
            SetTitle(lblLeftTitle, cmbLeft.SelectedIndex);
        }

        private void cmbRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTitle(lblRightTitle, cmbRight.SelectedIndex);
        }

        private void cmbBot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTitle(lblBottomTitle, cmbBot.SelectedIndex);
        }
    }
}
