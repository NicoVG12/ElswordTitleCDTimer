namespace TitleTimerUI.Controls.SettingsWindow
{
    partial class KeyBindingsControl
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
            txt135Key = new TextBox();
            txt156Key = new TextBox();
            lblPauseKeyDescription = new Label();
            lbl156Key = new Label();
            txt175Key = new TextBox();
            lblResetKeyDescription = new Label();
            lblResetKey = new Label();
            lblSave = new Label();
            label1 = new Label();
            txtOrderKey = new TextBox();
            lblOrderKeyDescription = new Label();
            lblOrderKey = new Label();
            lblMessage = new Label();
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
            lbl135Key.Text = "13-5 Key";
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
            lblStartKeyDescription.Text = "Initializes 13-5 Title Cooldown Timer (30s)";
            lblStartKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt135Key
            // 
            txt135Key.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt135Key.Location = new Point(264, 17);
            txt135Key.Name = "txt135Key";
            txt135Key.Size = new Size(49, 29);
            txt135Key.TabIndex = 6;
            txt135Key.TextAlign = HorizontalAlignment.Center;
            txt135Key.KeyDown += txtStartKey_KeyDown;
            txt135Key.KeyPress += txtStartKey_KeyPress;
            txt135Key.KeyUp += txtStartKey_KeyUp;
            // 
            // txt156Key
            // 
            txt156Key.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt156Key.Location = new Point(264, 71);
            txt156Key.Name = "txt156Key";
            txt156Key.Size = new Size(49, 29);
            txt156Key.TabIndex = 9;
            txt156Key.TextAlign = HorizontalAlignment.Center;
            txt156Key.KeyDown += txtPauseKey_KeyDown;
            txt156Key.KeyPress += txtPauseKey_KeyPress;
            txt156Key.KeyUp += txtPauseKey_KeyUp;
            // 
            // lblPauseKeyDescription
            // 
            lblPauseKeyDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPauseKeyDescription.ForeColor = Color.Black;
            lblPauseKeyDescription.Location = new Point(7, 70);
            lblPauseKeyDescription.Margin = new Padding(0);
            lblPauseKeyDescription.Name = "lblPauseKeyDescription";
            lblPauseKeyDescription.Size = new Size(255, 31);
            lblPauseKeyDescription.TabIndex = 8;
            lblPauseKeyDescription.Text = "Initializes 15-6 Title Cooldown Timer (25s)";
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
            lbl156Key.Text = "15-6 Key";
            // 
            // txt175Key
            // 
            txt175Key.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt175Key.Location = new Point(264, 125);
            txt175Key.Name = "txt175Key";
            txt175Key.Size = new Size(49, 29);
            txt175Key.TabIndex = 12;
            txt175Key.TextAlign = HorizontalAlignment.Center;
            txt175Key.KeyDown += txtResetKey_KeyDown;
            txt175Key.KeyPress += txtResetKey_KeyPress;
            txt175Key.KeyUp += txtResetKey_KeyUp;
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
            lblResetKeyDescription.Text = "Initializes 17-5 Title Cooldown Timer (60s)";
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
            lblResetKey.Text = "17-5 Key";
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
            // txtOrderKey
            // 
            txtOrderKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtOrderKey.Location = new Point(264, 179);
            txtOrderKey.Name = "txtOrderKey";
            txtOrderKey.Size = new Size(49, 29);
            txtOrderKey.TabIndex = 18;
            txtOrderKey.TextAlign = HorizontalAlignment.Center;
            txtOrderKey.KeyDown += txtOrderKey_KeyDown;
            txtOrderKey.KeyPress += txtOrderKey_KeyPress;
            txtOrderKey.KeyUp += txtOrderKey_KeyUp;
            // 
            // lblOrderKeyDescription
            // 
            lblOrderKeyDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderKeyDescription.ForeColor = Color.Black;
            lblOrderKeyDescription.Location = new Point(7, 178);
            lblOrderKeyDescription.Margin = new Padding(0);
            lblOrderKeyDescription.Name = "lblOrderKeyDescription";
            lblOrderKeyDescription.Size = new Size(255, 31);
            lblOrderKeyDescription.TabIndex = 17;
            lblOrderKeyDescription.Text = "Initializes Order Title Cooldown Timer (20s)";
            lblOrderKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOrderKey
            // 
            lblOrderKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderKey.ForeColor = Color.White;
            lblOrderKey.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblOrderKey.Location = new Point(4, 162);
            lblOrderKey.Margin = new Padding(0);
            lblOrderKey.Name = "lblOrderKey";
            lblOrderKey.Size = new Size(317, 49);
            lblOrderKey.TabIndex = 16;
            lblOrderKey.Text = "Order Key";
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
            lblMessage.Text = "The same key cannot be\r\nbound to multiple actions";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KeyBindingsControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lblMessage);
            Controls.Add(txtOrderKey);
            Controls.Add(lblOrderKeyDescription);
            Controls.Add(lblOrderKey);
            Controls.Add(txt175Key);
            Controls.Add(lblResetKeyDescription);
            Controls.Add(lblResetKey);
            Controls.Add(txt156Key);
            Controls.Add(lblPauseKeyDescription);
            Controls.Add(lbl156Key);
            Controls.Add(txt135Key);
            Controls.Add(lblStartKeyDescription);
            Controls.Add(lbl135Key);
            Controls.Add(lblSave);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "KeyBindingsControl";
            Size = new Size(326, 257);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl135Key;
        private Label lblStartKeyDescription;
        private TextBox txt135Key;
        private TextBox txt156Key;
        private Label lblPauseKeyDescription;
        private Label lbl156Key;
        private TextBox txt175Key;
        private Label lblResetKeyDescription;
        private Label lblResetKey;
        private Label lblSave;
        private Label label1;
        private TextBox txtOrderKey;
        private Label lblOrderKeyDescription;
        private Label lblOrderKey;
        private Label lblMessage;
    }
}
