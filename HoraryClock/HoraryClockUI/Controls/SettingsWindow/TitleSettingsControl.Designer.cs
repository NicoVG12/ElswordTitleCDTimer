namespace TitleTimerUI.Controls.SettingsWindow
{
    partial class TitleSettingsControl
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
            lbl135Key = new Label();
            lblStartKeyDescription = new Label();
            lblResetKey = new Label();
            lblSave = new Label();
            label1 = new Label();
            lblMessage = new Label();
            numDelay = new NumericUpDown();
            lbl156Key = new Label();
            lblTitleCross = new Label();
            lblBottomTitle = new Label();
            lblTopTitle = new Label();
            lblRightTitle = new Label();
            lblLeftTitle = new Label();
            cmbTop = new ComboBox();
            cmbLeft = new ComboBox();
            cmbRight = new ComboBox();
            cmbBot = new ComboBox();
            lblTopName = new Label();
            lblLeftName = new Label();
            lblRightName = new Label();
            lblBotName = new Label();
            ((System.ComponentModel.ISupportInitialize)numDelay).BeginInit();
            SuspendLayout();
            // 
            // lbl135Key
            // 
            lbl135Key.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl135Key.ForeColor = Color.White;
            lbl135Key.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lbl135Key.Location = new Point(4, 0);
            lbl135Key.Margin = new Padding(0);
            lbl135Key.Name = "lbl135Key";
            lbl135Key.Size = new Size(317, 49);
            lbl135Key.TabIndex = 1;
            lbl135Key.Text = "Title Switch Delay";
            // 
            // lblStartKeyDescription
            // 
            lblStartKeyDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartKeyDescription.ForeColor = Color.Black;
            lblStartKeyDescription.Location = new Point(7, 16);
            lblStartKeyDescription.Margin = new Padding(0);
            lblStartKeyDescription.Name = "lblStartKeyDescription";
            lblStartKeyDescription.Size = new Size(255, 31);
            lblStartKeyDescription.TabIndex = 5;
            lblStartKeyDescription.Text = "[Automatic Mode] Delay from when a title is selected to when a title is equipped (ms)";
            lblStartKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResetKey
            // 
            lblResetKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResetKey.ForeColor = Color.White;
            lblResetKey.Image = Properties.Resources.settings_control_bg1;
            lblResetKey.Location = new Point(4, 68);
            lblResetKey.Margin = new Padding(0);
            lblResetKey.Name = "lblResetKey";
            lblResetKey.Size = new Size(317, 89);
            lblResetKey.TabIndex = 10;
            // 
            // lblSave
            // 
            lblSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSave.ForeColor = Color.White;
            lblSave.Image = Properties.Resources.btnSave;
            lblSave.Location = new Point(112, 224);
            lblSave.Margin = new Padding(0);
            lblSave.Name = "lblSave";
            lblSave.Size = new Size(103, 27);
            lblSave.TabIndex = 15;
            lblSave.Text = "Save";
            lblSave.TextAlign = ContentAlignment.MiddleCenter;
            lblSave.Click += lblSave_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.settings_control_bg1;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(326, 257);
            label1.TabIndex = 14;
            label1.Text = "aaaaaaaaaaaaaaaaaaaa";
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.White;
            lblMessage.Image = Properties.Resources.Warning;
            lblMessage.Location = new Point(0, 217);
            lblMessage.Margin = new Padding(0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(326, 38);
            lblMessage.TabIndex = 19;
            lblMessage.Text = "The same key can be\r\nbound to multiple actions";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numDelay
            // 
            numDelay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numDelay.Location = new Point(264, 17);
            numDelay.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numDelay.Name = "numDelay";
            numDelay.Size = new Size(49, 29);
            numDelay.TabIndex = 20;
            // 
            // lbl156Key
            // 
            lbl156Key.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl156Key.ForeColor = Color.White;
            lbl156Key.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lbl156Key.Location = new Point(4, 54);
            lbl156Key.Margin = new Padding(0);
            lbl156Key.Name = "lbl156Key";
            lbl156Key.Size = new Size(317, 49);
            lbl156Key.TabIndex = 7;
            lbl156Key.Text = "Title Scheme";
            lbl156Key.Click += lbl156Key_Click;
            // 
            // lblTitleCross
            // 
            lblTitleCross.BackColor = Color.White;
            lblTitleCross.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleCross.ForeColor = Color.Silver;
            lblTitleCross.Image = Properties.Resources.Title_Cross1;
            lblTitleCross.Location = new Point(231, 123);
            lblTitleCross.Margin = new Padding(0);
            lblTitleCross.Name = "lblTitleCross";
            lblTitleCross.Size = new Size(32, 32);
            lblTitleCross.TabIndex = 21;
            // 
            // lblBottomTitle
            // 
            lblBottomTitle.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBottomTitle.ForeColor = Color.White;
            lblBottomTitle.Image = Properties.Resources.Title_Empty;
            lblBottomTitle.Location = new Point(224, 165);
            lblBottomTitle.Name = "lblBottomTitle";
            lblBottomTitle.Size = new Size(45, 45);
            lblBottomTitle.TabIndex = 22;
            lblBottomTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTopTitle
            // 
            lblTopTitle.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopTitle.ForeColor = Color.White;
            lblTopTitle.Image = Properties.Resources.Title_Empty;
            lblTopTitle.Location = new Point(224, 68);
            lblTopTitle.Name = "lblTopTitle";
            lblTopTitle.Size = new Size(45, 45);
            lblTopTitle.TabIndex = 23;
            lblTopTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRightTitle
            // 
            lblRightTitle.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRightTitle.ForeColor = Color.White;
            lblRightTitle.Image = Properties.Resources.Title_Empty;
            lblRightTitle.Location = new Point(273, 116);
            lblRightTitle.Name = "lblRightTitle";
            lblRightTitle.Size = new Size(45, 45);
            lblRightTitle.TabIndex = 24;
            lblRightTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLeftTitle
            // 
            lblLeftTitle.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLeftTitle.ForeColor = Color.White;
            lblLeftTitle.Image = Properties.Resources.Title_Empty;
            lblLeftTitle.Location = new Point(175, 116);
            lblLeftTitle.Name = "lblLeftTitle";
            lblLeftTitle.Size = new Size(45, 45);
            lblLeftTitle.TabIndex = 25;
            lblLeftTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbTop
            // 
            cmbTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbTop.FormattingEnabled = true;
            cmbTop.Location = new Point(53, 77);
            cmbTop.Name = "cmbTop";
            cmbTop.Size = new Size(108, 23);
            cmbTop.TabIndex = 26;
            cmbTop.SelectedIndexChanged += cmbTop_SelectedIndexChanged;
            // 
            // cmbLeft
            // 
            cmbLeft.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbLeft.FormattingEnabled = true;
            cmbLeft.Location = new Point(53, 112);
            cmbLeft.Name = "cmbLeft";
            cmbLeft.Size = new Size(108, 23);
            cmbLeft.TabIndex = 27;
            cmbLeft.SelectedValueChanged += cmbLeft_SelectedValueChanged;
            // 
            // cmbRight
            // 
            cmbRight.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbRight.FormattingEnabled = true;
            cmbRight.Location = new Point(53, 147);
            cmbRight.Name = "cmbRight";
            cmbRight.Size = new Size(108, 23);
            cmbRight.TabIndex = 28;
            cmbRight.SelectedIndexChanged += cmbRight_SelectedIndexChanged;
            // 
            // cmbBot
            // 
            cmbBot.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbBot.FormattingEnabled = true;
            cmbBot.Location = new Point(53, 182);
            cmbBot.Name = "cmbBot";
            cmbBot.Size = new Size(108, 23);
            cmbBot.TabIndex = 29;
            cmbBot.SelectedIndexChanged += cmbBot_SelectedIndexChanged;
            // 
            // lblTopName
            // 
            lblTopName.AutoSize = true;
            lblTopName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopName.ForeColor = Color.Black;
            lblTopName.Image = Properties.Resources.settings_control_bg1;
            lblTopName.Location = new Point(7, 80);
            lblTopName.Name = "lblTopName";
            lblTopName.Size = new Size(27, 15);
            lblTopName.TabIndex = 30;
            lblTopName.Text = "Top";
            // 
            // lblLeftName
            // 
            lblLeftName.AutoSize = true;
            lblLeftName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLeftName.ForeColor = Color.Black;
            lblLeftName.Image = Properties.Resources.settings_control_bg1;
            lblLeftName.Location = new Point(7, 117);
            lblLeftName.Name = "lblLeftName";
            lblLeftName.Size = new Size(27, 15);
            lblLeftName.TabIndex = 31;
            lblLeftName.Text = "Left";
            // 
            // lblRightName
            // 
            lblRightName.AutoSize = true;
            lblRightName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRightName.ForeColor = Color.Black;
            lblRightName.Image = Properties.Resources.settings_control_bg1;
            lblRightName.Location = new Point(7, 152);
            lblRightName.Name = "lblRightName";
            lblRightName.Size = new Size(35, 15);
            lblRightName.TabIndex = 32;
            lblRightName.Text = "Right";
            // 
            // lblBotName
            // 
            lblBotName.AutoSize = true;
            lblBotName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBotName.ForeColor = Color.Black;
            lblBotName.Image = Properties.Resources.settings_control_bg1;
            lblBotName.Location = new Point(7, 187);
            lblBotName.Name = "lblBotName";
            lblBotName.Size = new Size(47, 15);
            lblBotName.TabIndex = 33;
            lblBotName.Text = "Bottom";
            // 
            // TitleSettingsControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(cmbBot);
            Controls.Add(lblBotName);
            Controls.Add(cmbRight);
            Controls.Add(lblRightName);
            Controls.Add(lblLeftName);
            Controls.Add(lblTopName);
            Controls.Add(cmbLeft);
            Controls.Add(cmbTop);
            Controls.Add(lblLeftTitle);
            Controls.Add(lblRightTitle);
            Controls.Add(lblTopTitle);
            Controls.Add(lblBottomTitle);
            Controls.Add(lblTitleCross);
            Controls.Add(numDelay);
            Controls.Add(lblMessage);
            Controls.Add(lblResetKey);
            Controls.Add(lbl156Key);
            Controls.Add(lblStartKeyDescription);
            Controls.Add(lbl135Key);
            Controls.Add(lblSave);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "TitleSettingsControl";
            Size = new Size(326, 257);
            ((System.ComponentModel.ISupportInitialize)numDelay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl135Key;
        private Label lblStartKeyDescription;
        private Label lblResetKey;
        private Label lblSave;
        private Label label1;
        private Label lblMessage;
        private NumericUpDown numDelay;
        private Label lbl156Key;
        private Label lblTitleCross;
        private Label lblBottomTitle;
        private Label lblTopTitle;
        private Label lblRightTitle;
        private Label lblLeftTitle;
        private ComboBox cmbTop;
        private ComboBox cmbLeft;
        private ComboBox cmbRight;
        private ComboBox cmbBot;
        private Label lblTopName;
        private Label lblLeftName;
        private Label lblRightName;
        private Label lblBotName;
    }
}
