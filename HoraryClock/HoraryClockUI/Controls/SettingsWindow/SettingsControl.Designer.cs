namespace TitleTimerUI.Controls.SettingsWindow
{
    partial class SettingsControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            lblLanguage = new Label();
            lblPvPOffset = new Label();
            lblKeyBindings = new Label();
            lblActionKeys = new Label();
            lblBackground = new Label();
            pnlSpecificSettings = new FlowLayoutPanel();
            lblCommonKeySettings = new Label();
            lblTitleScheme = new Label();
            SuspendLayout();
            // 
            // lblLanguage
            // 
            lblLanguage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLanguage.ForeColor = Color.White;
            lblLanguage.Image = Properties.Resources.btnSettingNotSelected;
            lblLanguage.Location = new Point(27, 19);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(127, 27);
            lblLanguage.TabIndex = 0;
            lblLanguage.Text = "Language";
            lblLanguage.TextAlign = ContentAlignment.MiddleCenter;
            lblLanguage.Click += lblLanguage_Click;
            // 
            // lblPvPOffset
            // 
            lblPvPOffset.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPvPOffset.ForeColor = Color.White;
            lblPvPOffset.Image = Properties.Resources.btnSettingNotSelected;
            lblPvPOffset.Location = new Point(27, 19);
            lblPvPOffset.Name = "lblPvPOffset";
            lblPvPOffset.Size = new Size(127, 27);
            lblPvPOffset.TabIndex = 1;
            lblPvPOffset.Text = "Window";
            lblPvPOffset.TextAlign = ContentAlignment.MiddleCenter;
            lblPvPOffset.Click += lblPvPOffset_Click;
            // 
            // lblKeyBindings
            // 
            lblKeyBindings.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKeyBindings.ForeColor = Color.White;
            lblKeyBindings.Image = Properties.Resources.btnSettingNotSelected;
            lblKeyBindings.Location = new Point(27, 50);
            lblKeyBindings.Name = "lblKeyBindings";
            lblKeyBindings.Size = new Size(127, 27);
            lblKeyBindings.TabIndex = 2;
            lblKeyBindings.Text = "Title Keys";
            lblKeyBindings.TextAlign = ContentAlignment.MiddleCenter;
            lblKeyBindings.Click += lblKeyBindings_Click;
            // 
            // lblActionKeys
            // 
            lblActionKeys.BackColor = SystemColors.Control;
            lblActionKeys.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblActionKeys.ForeColor = Color.White;
            lblActionKeys.Image = Properties.Resources.btnSettingNotSelected;
            lblActionKeys.Location = new Point(27, 112);
            lblActionKeys.Name = "lblActionKeys";
            lblActionKeys.Size = new Size(127, 27);
            lblActionKeys.TabIndex = 3;
            lblActionKeys.Text = "Action Keys";
            lblActionKeys.TextAlign = ContentAlignment.MiddleCenter;
            lblActionKeys.Click += lblOther_Click;
            // 
            // lblBackground
            // 
            lblBackground.Image = (Image)resources.GetObject("lblBackground.Image");
            lblBackground.Location = new Point(0, 0);
            lblBackground.Margin = new Padding(0);
            lblBackground.Name = "lblBackground";
            lblBackground.Size = new Size(525, 292);
            lblBackground.TabIndex = 4;
            // 
            // pnlSpecificSettings
            // 
            pnlSpecificSettings.BackColor = Color.White;
            pnlSpecificSettings.Location = new Point(181, 17);
            pnlSpecificSettings.Margin = new Padding(0);
            pnlSpecificSettings.Name = "pnlSpecificSettings";
            pnlSpecificSettings.Size = new Size(326, 257);
            pnlSpecificSettings.TabIndex = 5;
            // 
            // lblCommonKeySettings
            // 
            lblCommonKeySettings.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCommonKeySettings.ForeColor = Color.White;
            lblCommonKeySettings.Image = Properties.Resources.btnSettingNotSelected;
            lblCommonKeySettings.Location = new Point(27, 81);
            lblCommonKeySettings.Name = "lblCommonKeySettings";
            lblCommonKeySettings.Size = new Size(127, 27);
            lblCommonKeySettings.TabIndex = 6;
            lblCommonKeySettings.Text = "Common Keys";
            lblCommonKeySettings.TextAlign = ContentAlignment.MiddleCenter;
            lblCommonKeySettings.Click += label1_Click;
            // 
            // lblTitleScheme
            // 
            lblTitleScheme.BackColor = SystemColors.Control;
            lblTitleScheme.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleScheme.ForeColor = Color.White;
            lblTitleScheme.Image = Properties.Resources.btnSettingNotSelected;
            lblTitleScheme.Location = new Point(27, 143);
            lblTitleScheme.Name = "lblTitleScheme";
            lblTitleScheme.Size = new Size(127, 27);
            lblTitleScheme.TabIndex = 7;
            lblTitleScheme.Text = "Title Scheme";
            lblTitleScheme.TextAlign = ContentAlignment.MiddleCenter;
            lblTitleScheme.Click += lblTitleScheme_Click;
            // 
            // SettingsControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lblTitleScheme);
            Controls.Add(lblCommonKeySettings);
            Controls.Add(pnlSpecificSettings);
            Controls.Add(lblActionKeys);
            Controls.Add(lblKeyBindings);
            Controls.Add(lblPvPOffset);
            Controls.Add(lblLanguage);
            Controls.Add(lblBackground);
            Margin = new Padding(0);
            Name = "SettingsControl";
            Size = new Size(525, 292);
            ResumeLayout(false);
        }

        #endregion

        private Label lblLanguage;
        private Label lblPvPOffset;
        private Label lblKeyBindings;
        private Label lblActionKeys;
        private Label lblBackground;
        private FlowLayoutPanel pnlSpecificSettings;
        private Label lblCommonKeySettings;
        private Label lblTitleScheme;
    }
}
