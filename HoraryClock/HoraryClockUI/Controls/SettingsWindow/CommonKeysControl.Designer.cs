namespace TitleTimerUI.Controls.SettingsWindow
{
    partial class CommonKeyBindingsControl
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
            lblResetAllKey = new Label();
            lblResetAllKeyDescription = new Label();
            txtResetAllKey = new TextBox();
            txtUnpauseAllKey = new TextBox();
            lblUnpauseAllKeyDescription = new Label();
            lblUnpauseAllKey = new Label();
            txtPauseAllKey = new TextBox();
            lblPauseAllKeyDescription = new Label();
            lblPauseAllKey = new Label();
            lblSave = new Label();
            label1 = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblResetAllKey
            // 
            lblResetAllKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResetAllKey.ForeColor = Color.White;
            lblResetAllKey.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblResetAllKey.Location = new Point(4, 0);
            lblResetAllKey.Margin = new Padding(0);
            lblResetAllKey.Name = "lblResetAllKey";
            lblResetAllKey.Size = new Size(317, 49);
            lblResetAllKey.TabIndex = 1;
            lblResetAllKey.Text = "Reset All Titles Key";
            // 
            // lblResetAllKeyDescription
            // 
            lblResetAllKeyDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResetAllKeyDescription.ForeColor = Color.Black;
            lblResetAllKeyDescription.Location = new Point(7, 16);
            lblResetAllKeyDescription.Margin = new Padding(0);
            lblResetAllKeyDescription.Name = "lblResetAllKeyDescription";
            lblResetAllKeyDescription.Size = new Size(255, 31);
            lblResetAllKeyDescription.TabIndex = 5;
            lblResetAllKeyDescription.Text = "Resets all the timers to their initial state.";
            lblResetAllKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtResetAllKey
            // 
            txtResetAllKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtResetAllKey.Location = new Point(264, 17);
            txtResetAllKey.Name = "txtResetAllKey";
            txtResetAllKey.Size = new Size(49, 29);
            txtResetAllKey.TabIndex = 6;
            txtResetAllKey.TextAlign = HorizontalAlignment.Center;
            txtResetAllKey.KeyDown += txtStartKey_KeyDown;
            txtResetAllKey.KeyPress += txtStartKey_KeyPress;
            txtResetAllKey.KeyUp += txtStartKey_KeyUp;
            // 
            // txtUnpauseAllKey
            // 
            txtUnpauseAllKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUnpauseAllKey.Location = new Point(264, 71);
            txtUnpauseAllKey.Name = "txtUnpauseAllKey";
            txtUnpauseAllKey.Size = new Size(49, 29);
            txtUnpauseAllKey.TabIndex = 9;
            txtUnpauseAllKey.TextAlign = HorizontalAlignment.Center;
            txtUnpauseAllKey.KeyDown += txtPauseKey_KeyDown;
            txtUnpauseAllKey.KeyPress += txtPauseKey_KeyPress;
            txtUnpauseAllKey.KeyUp += txtPauseKey_KeyUp;
            // 
            // lblUnpauseAllKeyDescription
            // 
            lblUnpauseAllKeyDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnpauseAllKeyDescription.ForeColor = Color.Black;
            lblUnpauseAllKeyDescription.Location = new Point(7, 70);
            lblUnpauseAllKeyDescription.Margin = new Padding(0);
            lblUnpauseAllKeyDescription.Name = "lblUnpauseAllKeyDescription";
            lblUnpauseAllKeyDescription.Size = new Size(255, 31);
            lblUnpauseAllKeyDescription.TabIndex = 8;
            lblUnpauseAllKeyDescription.Text = "Unpauses every paused timer.";
            lblUnpauseAllKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
            lblUnpauseAllKeyDescription.Click += lblUnpauseAllKeyDescription_Click;
            // 
            // lblUnpauseAllKey
            // 
            lblUnpauseAllKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnpauseAllKey.ForeColor = Color.White;
            lblUnpauseAllKey.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblUnpauseAllKey.Location = new Point(4, 54);
            lblUnpauseAllKey.Margin = new Padding(0);
            lblUnpauseAllKey.Name = "lblUnpauseAllKey";
            lblUnpauseAllKey.Size = new Size(317, 49);
            lblUnpauseAllKey.TabIndex = 7;
            lblUnpauseAllKey.Text = "Unpause All Titles Key";
            // 
            // txtPauseAllKey
            // 
            txtPauseAllKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPauseAllKey.Location = new Point(264, 125);
            txtPauseAllKey.Name = "txtPauseAllKey";
            txtPauseAllKey.Size = new Size(49, 29);
            txtPauseAllKey.TabIndex = 12;
            txtPauseAllKey.TextAlign = HorizontalAlignment.Center;
            txtPauseAllKey.KeyDown += txtResetKey_KeyDown;
            txtPauseAllKey.KeyPress += txtResetKey_KeyPress;
            txtPauseAllKey.KeyUp += txtResetKey_KeyUp;
            // 
            // lblPauseAllKeyDescription
            // 
            lblPauseAllKeyDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPauseAllKeyDescription.ForeColor = Color.Black;
            lblPauseAllKeyDescription.Location = new Point(7, 124);
            lblPauseAllKeyDescription.Margin = new Padding(0);
            lblPauseAllKeyDescription.Name = "lblPauseAllKeyDescription";
            lblPauseAllKeyDescription.Size = new Size(255, 31);
            lblPauseAllKeyDescription.TabIndex = 11;
            lblPauseAllKeyDescription.Text = "Pauses every timer.";
            lblPauseAllKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPauseAllKey
            // 
            lblPauseAllKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPauseAllKey.ForeColor = Color.White;
            lblPauseAllKey.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblPauseAllKey.Location = new Point(4, 108);
            lblPauseAllKey.Margin = new Padding(0);
            lblPauseAllKey.Name = "lblPauseAllKey";
            lblPauseAllKey.Size = new Size(317, 49);
            lblPauseAllKey.TabIndex = 10;
            lblPauseAllKey.Text = "Pause All Titles Key";
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
            lblMessage.Text = "The same key cannot be\r\nbound to multiple actions";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CommonKeyBindingsControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lblMessage);
            Controls.Add(txtPauseAllKey);
            Controls.Add(lblPauseAllKeyDescription);
            Controls.Add(lblPauseAllKey);
            Controls.Add(txtUnpauseAllKey);
            Controls.Add(lblUnpauseAllKeyDescription);
            Controls.Add(lblUnpauseAllKey);
            Controls.Add(txtResetAllKey);
            Controls.Add(lblResetAllKeyDescription);
            Controls.Add(lblResetAllKey);
            Controls.Add(lblSave);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "CommonKeyBindingsControl";
            Size = new Size(326, 257);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResetAllKey;
        private Label lblResetAllKeyDescription;
        private TextBox txtResetAllKey;
        private TextBox txtUnpauseAllKey;
        private Label lblUnpauseAllKeyDescription;
        private Label lblUnpauseAllKey;
        private TextBox txtPauseAllKey;
        private Label lblPauseAllKeyDescription;
        private Label lblPauseAllKey;
        private Label lblSave;
        private Label label1;
        private Label lblMessage;
    }
}
