namespace TitleTimerUI.Controls.SettingsWindow
{
    partial class LanguageControl
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
            lblBackground = new Label();
            lblSave = new Label();
            lblLanguageSample = new Label();
            lblLanguageSampleMessage = new Label();
            SuspendLayout();
            // 
            // lblBackground
            // 
            lblBackground.Image = Properties.Resources.keys_settings_control_bg1;
            lblBackground.Location = new Point(0, 0);
            lblBackground.Margin = new Padding(0);
            lblBackground.Name = "lblBackground";
            lblBackground.Size = new Size(326, 257);
            lblBackground.TabIndex = 1;
            lblBackground.Click += lblBackground_Click;
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
            lblSave.TabIndex = 16;
            lblSave.Text = "Save";
            lblSave.TextAlign = ContentAlignment.MiddleCenter;
            lblSave.Click += lblSave_Click;
            // 
            // lblLanguageSample
            // 
            lblLanguageSample.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLanguageSample.ForeColor = Color.White;
            lblLanguageSample.Image = Properties.Resources.btnRoundRct_Active_Small;
            lblLanguageSample.Location = new Point(35, 16);
            lblLanguageSample.Margin = new Padding(0);
            lblLanguageSample.Name = "lblLanguageSample";
            lblLanguageSample.Size = new Size(105, 29);
            lblLanguageSample.TabIndex = 17;
            lblLanguageSample.Text = "English";
            lblLanguageSample.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLanguageSampleMessage
            // 
            lblLanguageSampleMessage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLanguageSampleMessage.ForeColor = Color.White;
            lblLanguageSampleMessage.Image = Properties.Resources.keys_settings_label_bg;
            lblLanguageSampleMessage.Location = new Point(35, 171);
            lblLanguageSampleMessage.Margin = new Padding(0);
            lblLanguageSampleMessage.Name = "lblLanguageSampleMessage";
            lblLanguageSampleMessage.Size = new Size(255, 38);
            lblLanguageSampleMessage.TabIndex = 18;
            lblLanguageSampleMessage.Text = "The language will be set to English.";
            lblLanguageSampleMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LanguageControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lblLanguageSample);
            Controls.Add(lblLanguageSampleMessage);
            Controls.Add(lblSave);
            Controls.Add(lblBackground);
            Margin = new Padding(0);
            Name = "LanguageControl";
            Size = new Size(326, 257);
            ResumeLayout(false);
        }

        #endregion

        private Label lblBackground;
        private Label lblSave;
        private Label lblLanguageSample;
        private Label lblLanguageSampleMessage;
    }
}
