namespace TitleTimerUI.Controls.SettingsWindow
{
    partial class ClockSettingsControl
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
            lblOpacity = new Label();
            lblAlwaysOnTop = new Label();
            lblOpacityDescription = new Label();
            lblAlwaysOnTopDescription = new Label();
            chkAlwaysOnTop = new CheckBox();
            lblSave = new Label();
            trkOpacity = new TrackBar();
            lblOpacityProgress = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)trkOpacity).BeginInit();
            SuspendLayout();
            // 
            // lblOpacity
            // 
            lblOpacity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpacity.ForeColor = Color.White;
            lblOpacity.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblOpacity.Location = new Point(4, 1);
            lblOpacity.Margin = new Padding(0);
            lblOpacity.Name = "lblOpacity";
            lblOpacity.Size = new Size(317, 49);
            lblOpacity.TabIndex = 2;
            lblOpacity.Text = "Window's Opacity";
            // 
            // lblAlwaysOnTop
            // 
            lblAlwaysOnTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlwaysOnTop.ForeColor = Color.White;
            lblAlwaysOnTop.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblAlwaysOnTop.Location = new Point(4, 55);
            lblAlwaysOnTop.Margin = new Padding(0);
            lblAlwaysOnTop.Name = "lblAlwaysOnTop";
            lblAlwaysOnTop.Size = new Size(317, 49);
            lblAlwaysOnTop.TabIndex = 3;
            lblAlwaysOnTop.Text = "Window Always on Top";
            // 
            // lblOpacityDescription
            // 
            lblOpacityDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpacityDescription.ForeColor = Color.Black;
            lblOpacityDescription.Location = new Point(7, 17);
            lblOpacityDescription.Margin = new Padding(0);
            lblOpacityDescription.Name = "lblOpacityDescription";
            lblOpacityDescription.Size = new Size(146, 31);
            lblOpacityDescription.TabIndex = 6;
            lblOpacityDescription.Text = "Set the window's opacity.\r\n(10%~100%)";
            lblOpacityDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAlwaysOnTopDescription
            // 
            lblAlwaysOnTopDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlwaysOnTopDescription.ForeColor = Color.Black;
            lblAlwaysOnTopDescription.Location = new Point(7, 71);
            lblAlwaysOnTopDescription.Margin = new Padding(0);
            lblAlwaysOnTopDescription.Name = "lblAlwaysOnTopDescription";
            lblAlwaysOnTopDescription.Size = new Size(255, 31);
            lblAlwaysOnTopDescription.TabIndex = 7;
            lblAlwaysOnTopDescription.Text = "The window will always stay on top.";
            lblAlwaysOnTopDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkAlwaysOnTop
            // 
            chkAlwaysOnTop.Location = new Point(291, 71);
            chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            chkAlwaysOnTop.Size = new Size(28, 31);
            chkAlwaysOnTop.TabIndex = 12;
            chkAlwaysOnTop.UseVisualStyleBackColor = true;
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
            lblSave.TabIndex = 13;
            lblSave.Text = "Save";
            lblSave.TextAlign = ContentAlignment.MiddleCenter;
            lblSave.Click += lblSave_Click;
            // 
            // trkOpacity
            // 
            trkOpacity.AutoSize = false;
            trkOpacity.Location = new Point(215, 17);
            trkOpacity.Maximum = 9;
            trkOpacity.Name = "trkOpacity";
            trkOpacity.Size = new Size(104, 31);
            trkOpacity.TabIndex = 14;
            trkOpacity.Scroll += trkOpacity_Scroll;
            // 
            // lblOpacityProgress
            // 
            lblOpacityProgress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpacityProgress.ForeColor = Color.Black;
            lblOpacityProgress.Location = new Point(153, 17);
            lblOpacityProgress.Margin = new Padding(0);
            lblOpacityProgress.Name = "lblOpacityProgress";
            lblOpacityProgress.Size = new Size(62, 31);
            lblOpacityProgress.TabIndex = 15;
            lblOpacityProgress.Text = "100%";
            lblOpacityProgress.TextAlign = ContentAlignment.MiddleRight;
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
            label1.TabIndex = 8;
            // 
            // ClockSettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblOpacityProgress);
            Controls.Add(trkOpacity);
            Controls.Add(lblSave);
            Controls.Add(chkAlwaysOnTop);
            Controls.Add(lblAlwaysOnTopDescription);
            Controls.Add(lblOpacityDescription);
            Controls.Add(lblAlwaysOnTop);
            Controls.Add(lblOpacity);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "ClockSettingsControl";
            Size = new Size(326, 257);
            ((System.ComponentModel.ISupportInitialize)trkOpacity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSave;
        private Label lblOpacity;
        private Label lblAlwaysOnTop;
        private Label lblOpacityDescription;
        private Label lblAlwaysOnTopDescription;
        private CheckBox chkAlwaysOnTop;
        private TrackBar trkOpacity;
        private Label lblOpacityProgress;
        private Label label1;
    }
}
