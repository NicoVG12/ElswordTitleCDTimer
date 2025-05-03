namespace TitleTimerUI.Controls.SettingsWindow
{
    partial class ActionKeysControl
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
            txtAwkKey = new TextBox();
            txtOnionAlt = new TextBox();
            lblPauseKeyDescription = new Label();
            lbl156Key = new Label();
            txtTitleSwitch = new TextBox();
            lblResetKeyDescription = new Label();
            lblResetKey = new Label();
            lblSave = new Label();
            label1 = new Label();
            lblMessage = new Label();
            txtOnion = new TextBox();
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
            lbl135Key.Text = "Awakening Key";
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
            lblStartKeyDescription.Text = "[Automatic Mode] Key used to detect character awakening";
            lblStartKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAwkKey
            // 
            txtAwkKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAwkKey.Location = new Point(264, 17);
            txtAwkKey.Name = "txtAwkKey";
            txtAwkKey.Size = new Size(49, 29);
            txtAwkKey.TabIndex = 6;
            txtAwkKey.TextAlign = HorizontalAlignment.Center;
            txtAwkKey.KeyDown += txtStartKey_KeyDown;
            txtAwkKey.KeyPress += txtStartKey_KeyPress;
            txtAwkKey.KeyUp += txtStartKey_KeyUp;
            // 
            // txtOnionAlt
            // 
            txtOnionAlt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtOnionAlt.Location = new Point(264, 71);
            txtOnionAlt.Name = "txtOnionAlt";
            txtOnionAlt.Size = new Size(49, 29);
            txtOnionAlt.TabIndex = 9;
            txtOnionAlt.TextAlign = HorizontalAlignment.Center;
            txtOnionAlt.KeyDown += txtPauseKey_KeyDown;
            txtOnionAlt.KeyPress += txtPauseKey_KeyPress;
            txtOnionAlt.KeyUp += txtPauseKey_KeyUp;
            // 
            // lblPauseKeyDescription
            // 
            lblPauseKeyDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPauseKeyDescription.ForeColor = Color.Black;
            lblPauseKeyDescription.Location = new Point(7, 70);
            lblPauseKeyDescription.Margin = new Padding(0);
            lblPauseKeyDescription.Name = "lblPauseKeyDescription";
            lblPauseKeyDescription.Size = new Size(203, 31);
            lblPauseKeyDescription.TabIndex = 8;
            lblPauseKeyDescription.Text = "[Automatic Mode] Keys used to detect awakening Onion/Apple usage";
            lblPauseKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
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
            lbl156Key.Text = "Onion Keys";
            // 
            // txtTitleSwitch
            // 
            txtTitleSwitch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitleSwitch.Location = new Point(264, 125);
            txtTitleSwitch.Name = "txtTitleSwitch";
            txtTitleSwitch.Size = new Size(49, 29);
            txtTitleSwitch.TabIndex = 12;
            txtTitleSwitch.TextAlign = HorizontalAlignment.Center;
            txtTitleSwitch.KeyDown += txtResetKey_KeyDown;
            txtTitleSwitch.KeyPress += txtResetKey_KeyPress;
            txtTitleSwitch.KeyUp += txtResetKey_KeyUp;
            // 
            // lblResetKeyDescription
            // 
            lblResetKeyDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResetKeyDescription.ForeColor = Color.Black;
            lblResetKeyDescription.Location = new Point(7, 124);
            lblResetKeyDescription.Margin = new Padding(0);
            lblResetKeyDescription.Name = "lblResetKeyDescription";
            lblResetKeyDescription.Size = new Size(255, 31);
            lblResetKeyDescription.TabIndex = 11;
            lblResetKeyDescription.Text = "[Automatic Mode] Key used to detect Title Switch system opening";
            lblResetKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResetKey
            // 
            lblResetKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResetKey.ForeColor = Color.White;
            lblResetKey.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblResetKey.Location = new Point(4, 108);
            lblResetKey.Margin = new Padding(0);
            lblResetKey.Name = "lblResetKey";
            lblResetKey.Size = new Size(317, 49);
            lblResetKey.TabIndex = 10;
            lblResetKey.Text = "Title Switch Key";
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
            // txtOnion
            // 
            txtOnion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtOnion.Location = new Point(213, 71);
            txtOnion.Name = "txtOnion";
            txtOnion.Size = new Size(49, 29);
            txtOnion.TabIndex = 20;
            txtOnion.TextAlign = HorizontalAlignment.Center;
            txtOnion.KeyDown += txtOnion_KeyDown;
            txtOnion.KeyPress += txtOnion_KeyPress;
            txtOnion.KeyUp += txtOnion_KeyUp;
            // 
            // ActionKeysControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(txtOnion);
            Controls.Add(lblMessage);
            Controls.Add(txtTitleSwitch);
            Controls.Add(lblResetKeyDescription);
            Controls.Add(lblResetKey);
            Controls.Add(txtOnionAlt);
            Controls.Add(lblPauseKeyDescription);
            Controls.Add(lbl156Key);
            Controls.Add(txtAwkKey);
            Controls.Add(lblStartKeyDescription);
            Controls.Add(lbl135Key);
            Controls.Add(lblSave);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "ActionKeysControl";
            Size = new Size(326, 257);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl135Key;
        private Label lblStartKeyDescription;
        private TextBox txtAwkKey;
        private TextBox txtOnionAlt;
        private Label lblPauseKeyDescription;
        private Label lbl156Key;
        private TextBox txtTitleSwitch;
        private Label lblResetKeyDescription;
        private Label lblResetKey;
        private Label lblSave;
        private Label label1;
        private Label lblMessage;
        private TextBox txtOnion;
    }
}
