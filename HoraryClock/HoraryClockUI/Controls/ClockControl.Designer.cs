namespace TitleTimerUI.Controls
{
    partial class ClockControl
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
            lblSettings = new Label();
            lblStart = new Label();
            lblPause = new Label();
            lblReset = new Label();
            lblRemainingTime = new Label();
            lblRemainingTimeValue = new Label();
            lblCurrentEffect = new Label();
            lblCurrentEffectIcon = new Label();
            lblFirstDescription = new Label();
            lblSecondDescription = new Label();
            lblBackground = new Label();
            SuspendLayout();
            // 
            // lblSettings
            // 
            lblSettings.Image = Properties.Resources.btnSettingsDarkBackgroundNotHovered;
            lblSettings.Location = new Point(469, 13);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(35, 46);
            lblSettings.TabIndex = 0;
            lblSettings.Click += lblSettings_Click;
            // 
            // lblStart
            // 
            lblStart.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStart.ForeColor = Color.White;
            lblStart.Image = Properties.Resources.btnRctg_0;
            lblStart.Location = new Point(19, 240);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(146, 40);
            lblStart.TabIndex = 1;
            lblStart.Text = "Start";
            lblStart.TextAlign = ContentAlignment.MiddleCenter;
            lblStart.Click += lblStart_Click;
            // 
            // lblPause
            // 
            lblPause.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPause.ForeColor = Color.White;
            lblPause.Image = Properties.Resources.btnRctg_0;
            lblPause.Location = new Point(190, 240);
            lblPause.Name = "lblPause";
            lblPause.Size = new Size(146, 40);
            lblPause.TabIndex = 2;
            lblPause.Text = "Pause";
            lblPause.TextAlign = ContentAlignment.MiddleCenter;
            lblPause.Click += lblPause_Click;
            // 
            // lblReset
            // 
            lblReset.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblReset.ForeColor = Color.White;
            lblReset.Image = Properties.Resources.btnRctg_0;
            lblReset.Location = new Point(361, 240);
            lblReset.Name = "lblReset";
            lblReset.Size = new Size(146, 40);
            lblReset.TabIndex = 3;
            lblReset.Text = "Reset";
            lblReset.TextAlign = ContentAlignment.MiddleCenter;
            lblReset.Click += lblReset_Click;
            // 
            // lblRemainingTime
            // 
            lblRemainingTime.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemainingTime.ForeColor = Color.White;
            lblRemainingTime.Image = Properties.Resources.lblBackgroundDark;
            lblRemainingTime.Location = new Point(22, 194);
            lblRemainingTime.Name = "lblRemainingTime";
            lblRemainingTime.Size = new Size(218, 32);
            lblRemainingTime.TabIndex = 4;
            lblRemainingTime.Text = "Remaining Time: ";
            lblRemainingTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRemainingTimeValue
            // 
            lblRemainingTimeValue.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemainingTimeValue.ForeColor = Color.White;
            lblRemainingTimeValue.Image = Properties.Resources.lblBackgroundDark;
            lblRemainingTimeValue.Location = new Point(255, 194);
            lblRemainingTimeValue.Name = "lblRemainingTimeValue";
            lblRemainingTimeValue.Size = new Size(240, 32);
            lblRemainingTimeValue.TabIndex = 5;
            lblRemainingTimeValue.Text = "-";
            lblRemainingTimeValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrentEffect
            // 
            lblCurrentEffect.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentEffect.ForeColor = Color.White;
            lblCurrentEffect.Image = Properties.Resources.lblBackgroundDark;
            lblCurrentEffect.Location = new Point(39, 17);
            lblCurrentEffect.Name = "lblCurrentEffect";
            lblCurrentEffect.Size = new Size(448, 30);
            lblCurrentEffect.TabIndex = 6;
            lblCurrentEffect.Text = "Current Effect";
            lblCurrentEffect.TextAlign = ContentAlignment.MiddleCenter;
            lblCurrentEffect.Click += label1_Click;
            // 
            // lblCurrentEffectIcon
            // 
            lblCurrentEffectIcon.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentEffectIcon.ForeColor = Color.Black;
            lblCurrentEffectIcon.Image = Properties.Resources._04noeffect;
            lblCurrentEffectIcon.Location = new Point(240, 56);
            lblCurrentEffectIcon.Name = "lblCurrentEffectIcon";
            lblCurrentEffectIcon.Size = new Size(45, 45);
            lblCurrentEffectIcon.TabIndex = 7;
            lblCurrentEffectIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstDescription
            // 
            lblFirstDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstDescription.ForeColor = Color.White;
            lblFirstDescription.Image = Properties.Resources.lblBackgroundDark;
            lblFirstDescription.Location = new Point(39, 101);
            lblFirstDescription.Name = "lblFirstDescription";
            lblFirstDescription.Size = new Size(448, 40);
            lblFirstDescription.TabIndex = 8;
            lblFirstDescription.Text = "First Effect Line";
            lblFirstDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSecondDescription
            // 
            lblSecondDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecondDescription.ForeColor = Color.White;
            lblSecondDescription.Image = Properties.Resources.lblBackgroundDark;
            lblSecondDescription.Location = new Point(39, 131);
            lblSecondDescription.Name = "lblSecondDescription";
            lblSecondDescription.Size = new Size(448, 40);
            lblSecondDescription.TabIndex = 9;
            lblSecondDescription.Text = "Second Effect Line";
            lblSecondDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBackground
            // 
            lblBackground.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBackground.ForeColor = Color.Black;
            lblBackground.Image = Properties.Resources.background_control_clock;
            lblBackground.Location = new Point(0, 0);
            lblBackground.Margin = new Padding(0);
            lblBackground.Name = "lblBackground";
            lblBackground.Size = new Size(525, 292);
            lblBackground.TabIndex = 10;
            lblBackground.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ClockControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lblSettings);
            Controls.Add(lblCurrentEffectIcon);
            Controls.Add(lblFirstDescription);
            Controls.Add(lblSecondDescription);
            Controls.Add(lblCurrentEffect);
            Controls.Add(lblRemainingTimeValue);
            Controls.Add(lblRemainingTime);
            Controls.Add(lblReset);
            Controls.Add(lblPause);
            Controls.Add(lblStart);
            Controls.Add(lblBackground);
            Margin = new Padding(0);
            Name = "ClockControl";
            Size = new Size(525, 292);
            ResumeLayout(false);
        }

        #endregion

        private Label lblSettings;
        private Label lblStart;
        private Label lblPause;
        private Label lblReset;
        private Label lblRemainingTime;
        private Label lblRemainingTimeValue;
        private Label lblCurrentEffect;
        private Label lblCurrentEffectIcon;
        private Label lblFirstDescription;
        private Label lblSecondDescription;
        private Label lblBackground;
    }
}
