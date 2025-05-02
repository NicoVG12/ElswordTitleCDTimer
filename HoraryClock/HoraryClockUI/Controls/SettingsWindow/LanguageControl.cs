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
    public partial class LanguageControl : UserControl, ILanguageSetter
    {
        private MainForm _mainForm;
        private Config _config = Config.Instance();
        private LanguageManager _languageManager = LanguageManager.Instance();
        private Label[] _languageButtons = new Label[LanguageManager.LANGUAGE_AMOUNT];
        private string[] _languageMessages = new string[LanguageManager.LANGUAGE_AMOUNT];
        private int _newActiveLanguage = 0;
        public LanguageControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            _newActiveLanguage = _config.LanguageId;

            InitializeComponent();
            LoadLanguageButtons();
            LoadHoverImages();
            SetLanguage(_languageManager.GetLanguageData(_newActiveLanguage));

            lblLanguageSample.Visible = false;
        }

        private void LoadHoverImages()
        {
            HoverUtils.SetHoverImages(lblSave, Properties.Resources.btnSave, Properties.Resources.btnSaveHover1);
        }

        private void LoadLanguageButtons()
        {
            int lblWidth = 105;
            int lblHeight = 29;
            int LocationXDefault = 6;
            int LocationX = LocationXDefault;
            int LocationY = 16;

            for (int i = 0; i < LanguageManager.LANGUAGE_AMOUNT; i++)
            {
                LanguageData languageData = _languageManager.GetLanguageData(i);
                Label lblLanguage = new Label();
                Controls.Add(lblLanguage);

                lblLanguage.BringToFront();
                lblLanguage.Text = languageData.Name;
                lblLanguage.AutoSize = false;
                lblLanguage.Location = new Point(LocationX, LocationY);
                lblLanguage.Size = new Size(lblWidth, lblHeight);
                lblLanguage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
                lblLanguage.ForeColor = Color.White;
                lblLanguage.Margin = new Padding(0);
                lblLanguage.Name = "lblLanguage" + i;
                lblLanguage.TabIndex = 17 + i;
                lblLanguage.TextAlign = ContentAlignment.MiddleCenter;
                lblLanguage.Visible = true;

                int languageIndex = i;
                lblLanguage.Click += delegate { SetActiveLanguage(languageIndex); };
                HoverUtils.SetHoverImages(lblLanguage, Properties.Resources.btnRoundRct_Unactive_Small, Properties.Resources.btnRoundRct_Active_Small);
                lblLanguage.MouseLeave += delegate { MouseLeave(lblLanguage, languageIndex); };

                _languageButtons[i] = lblLanguage;
                _languageMessages[i] = languageData.SampleMessage;

                LocationX += lblWidth;
                if ((i + 1) % 3 == 0)
                {
                    LocationX = LocationXDefault;
                    LocationY += lblHeight;
                }
            }


            Refresh();
            SetActiveLanguage(_config.LanguageId);
        }

        private void SetActiveLanguage(int languageId)
        {
            foreach (Label languageButton in _languageButtons)
            {
                languageButton.Image = Properties.Resources.btnRoundRct_Unactive_Small;
            }

            _languageButtons[languageId].Image = Properties.Resources.btnRoundRct_Active_Small;
            lblLanguageSampleMessage.Text = _languageMessages[languageId];

            _newActiveLanguage = languageId;
        }

        public void SetLanguage(LanguageData languageData)
        {
            lblSave.Text = languageData.Settings.Save;
            lblLanguageSampleMessage.Text = languageData.SampleMessage;
        }

        public void MouseLeave(Label label, int languageId)
        {
            if (languageId == _newActiveLanguage)
            {
                label.Image = Properties.Resources.btnRoundRct_Active_Small;
            }
            else
            {
                label.Image = Properties.Resources.btnRoundRct_Unactive_Small;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            _mainForm.LoadConfig();
            _mainForm.SetLanguage(GetActiveLanguage());
            _config.LanguageId = GetActiveLanguageId();
            _config.Save();
        }

        private int GetActiveLanguageId()
        {
            return _newActiveLanguage;
        }
        private LanguageData GetActiveLanguage()
        {
            return _languageManager.GetLanguageData(_newActiveLanguage);
        }

        private void lblBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
