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
    public partial class SettingsControl : UserControl, ILanguageSetter
    {
        private const int CONTROL_AMOUNT = 6;

        private const int LANGUAGE_SETTINGS_ID = 0;
        private const int CLOCK_SETTINGS_ID = 1;
        private const int KEY_SETTINGS_ID = 2;
        private const int COMMON_KEYS_SETTINGS_ID = 3;
        private const int ACTION_KEYS_SETTINGS_ID = 4;
        private const int TITLE_SCHEME_SETTINGS_ID = 5;

        private Label[] _labels = new Label[CONTROL_AMOUNT];
        private bool[] _settingSelected = new bool[CONTROL_AMOUNT];
        private Control[] _settingsControls = new Control[CONTROL_AMOUNT];
        private MainForm _mainForm;
        public SettingsControl(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();
            InitializeLabelArray();
            InitializeControls();
            InitializeHoverIcons();
            SetSelected(CLOCK_SETTINGS_ID);
            Refresh();

        }

        private void InitializeLabelArray()
        {
            _labels[LANGUAGE_SETTINGS_ID] = lblLanguage;
            _labels[CLOCK_SETTINGS_ID] = lblPvPOffset;
            _labels[KEY_SETTINGS_ID] = lblKeyBindings;
            _labels[COMMON_KEYS_SETTINGS_ID] = lblCommonKeySettings;
            _labels[ACTION_KEYS_SETTINGS_ID] = lblActionKeys;
            _labels[TITLE_SCHEME_SETTINGS_ID] = lblTitleScheme;
        }

        private void InitializeControls()
        {
            _settingsControls[LANGUAGE_SETTINGS_ID] = new LanguageControl(_mainForm);
            _settingsControls[CLOCK_SETTINGS_ID] = new ClockSettingsControl(_mainForm);
            _settingsControls[KEY_SETTINGS_ID] = new KeyBindingsControl(_mainForm);
            _settingsControls[COMMON_KEYS_SETTINGS_ID] = new CommonKeyBindingsControl(_mainForm);
            _settingsControls[ACTION_KEYS_SETTINGS_ID] = new ActionKeysControl(_mainForm);
            _settingsControls[TITLE_SCHEME_SETTINGS_ID] = new TitleSettingsControl(_mainForm);
        }

        private void SetSelected(int settingId)
        {
            if (!_settingSelected[settingId])
            {
                UnselectAllSettings();
                _settingSelected[settingId] = true;
                _labels[settingId].Image = Properties.Resources.btnSettingSelected;

                pnlSpecificSettings.Controls.Clear();
                pnlSpecificSettings.Controls.Add(_settingsControls[settingId]);
                pnlSpecificSettings.Refresh();
                Refresh();
            }
        }

        private void UnselectAllSettings()
        {
            for (int i = 0; i < _settingSelected.Length; i++)
            {
                _settingSelected[i] = false;
                _labels[i].Image = Properties.Resources.btnSettingNotSelected;
            }
        }

        private void lblLanguage_Click(object sender, EventArgs e)
        {
            SetSelected(LANGUAGE_SETTINGS_ID);
        }

        private void lblPvPOffset_Click(object sender, EventArgs e)
        {
            SetSelected(CLOCK_SETTINGS_ID);
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            _mainForm.ShowTab(MainForm.CLOCK_ID);
        }

        private void InitializeHoverIcons()
        {
            lblLanguage.MouseEnter += OnMouseEnterLanguage;
            lblLanguage.MouseLeave += OnMouseLeaveLanguage;
            lblPvPOffset.MouseEnter += OnMouseEnterClock;
            lblPvPOffset.MouseLeave += OnMouseLeaveClock;
            lblKeyBindings.MouseEnter += OnMouseEnterKeys;
            lblKeyBindings.MouseLeave += OnMouseLeaveKeys;
            lblActionKeys.MouseEnter += OnMouseEnterOther;
            lblActionKeys.MouseLeave += OnMouseLeaveOther;
            lblCommonKeySettings.MouseEnter += OnMouseEnterCommonKeySettings;
            lblCommonKeySettings.MouseLeave += OnMouseLeaveCommonKeySettings;
            lblTitleScheme.MouseEnter += OnMouseEnterTitleSchemeSettings;
            lblTitleScheme.MouseLeave += OnMouseLeaveTileSchemeSettings;
        }

        private void Other_MouseEnter(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnMouseEnterLanguage(object sender, EventArgs e)
        {
            if (!_settingSelected[LANGUAGE_SETTINGS_ID])
            {
                lblLanguage.Image = Properties.Resources.btnSettingHovered;
            }
        }

        private void OnMouseLeaveLanguage(object sender, EventArgs e)
        {
            if (!_settingSelected[LANGUAGE_SETTINGS_ID])
            {
                lblLanguage.Image = Properties.Resources.btnSettingNotSelected;
            }
        }

        private void OnMouseEnterClock(object sender, EventArgs e)
        {
            if (!_settingSelected[CLOCK_SETTINGS_ID])
            {
                lblPvPOffset.Image = Properties.Resources.btnSettingHovered;
            }
        }

        private void OnMouseLeaveClock(object sender, EventArgs e)
        {
            if (!_settingSelected[CLOCK_SETTINGS_ID])
            {
                lblPvPOffset.Image = Properties.Resources.btnSettingNotSelected;
            }
        }

        private void OnMouseEnterKeys(object sender, EventArgs e)
        {
            if (!_settingSelected[KEY_SETTINGS_ID])
            {
                lblKeyBindings.Image = Properties.Resources.btnSettingHovered;
            }
        }

        private void OnMouseLeaveKeys(object sender, EventArgs e)
        {
            if (!_settingSelected[KEY_SETTINGS_ID])
            {
                lblKeyBindings.Image = Properties.Resources.btnSettingNotSelected;
            }
        }

        private void OnMouseEnterOther(object sender, EventArgs e)
        {
            if (!_settingSelected[ACTION_KEYS_SETTINGS_ID])
            {
                lblActionKeys.Image = Properties.Resources.btnSettingHovered;
            }
        }

        private void OnMouseLeaveOther(object sender, EventArgs e)
        {
            if (!_settingSelected[ACTION_KEYS_SETTINGS_ID])
            {
                lblActionKeys.Image = Properties.Resources.btnSettingNotSelected;
            }
        }


        private void lblKeyBindings_Click(object sender, EventArgs e)
        {
            SetSelected(KEY_SETTINGS_ID);
        }

        public void SetLanguage(LanguageData languageData)
        {
        }

        private void lblOther_Click(object sender, EventArgs e)
        {
            SetSelected(ACTION_KEYS_SETTINGS_ID);
        }

        private void OnMouseEnterCommonKeySettings(object sender, EventArgs e)
        {
            if (!_settingSelected[COMMON_KEYS_SETTINGS_ID])
            {
                lblCommonKeySettings.Image = Properties.Resources.btnSettingHovered;
            }
        }

        private void OnMouseLeaveCommonKeySettings(object sender, EventArgs e)
        {
            if (!_settingSelected[COMMON_KEYS_SETTINGS_ID])
            {
                lblCommonKeySettings.Image = Properties.Resources.btnSettingNotSelected;
            }
        }

        private void OnMouseEnterTitleSchemeSettings(object sender, EventArgs e)
        {
            if (!_settingSelected[TITLE_SCHEME_SETTINGS_ID])
            {
                lblTitleScheme.Image = Properties.Resources.btnSettingHovered;
            }
        }

        private void OnMouseLeaveTileSchemeSettings(object sender, EventArgs e)
        {
            if (!_settingSelected[TITLE_SCHEME_SETTINGS_ID])
            {
                lblTitleScheme.Image = Properties.Resources.btnSettingNotSelected;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SetSelected(COMMON_KEYS_SETTINGS_ID);
        }

        private void lblTitleScheme_Click(object sender, EventArgs e)
        {
            SetSelected(TITLE_SCHEME_SETTINGS_ID);
        }
    }
}
