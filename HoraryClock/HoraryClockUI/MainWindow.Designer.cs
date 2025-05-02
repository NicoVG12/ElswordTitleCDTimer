namespace TitleTimerUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBackground = new Label();
            mainPanel = new FlowLayoutPanel();
            lblCloseWindow = new Label();
            lblMinimize = new Label();
            SuspendLayout();
            // 
            // lblBackground
            // 
            lblBackground.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBackground.ForeColor = Color.White;
            lblBackground.Image = Properties.Resources.background;
            lblBackground.Location = new Point(0, 0);
            lblBackground.Margin = new Padding(0);
            lblBackground.Name = "lblBackground";
            lblBackground.Padding = new Padding(10);
            lblBackground.Size = new Size(529, 332);
            lblBackground.TabIndex = 1;
            lblBackground.Text = "Horary Clock Tool v2.0";
            lblBackground.MouseDown += lblBackground_MouseDown;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(2, 38);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(525, 292);
            mainPanel.TabIndex = 2;
            // 
            // lblCloseWindow
            // 
            lblCloseWindow.Image = Properties.Resources.btnClose_normal;
            lblCloseWindow.Location = new Point(498, 2);
            lblCloseWindow.Name = "lblCloseWindow";
            lblCloseWindow.Size = new Size(29, 28);
            lblCloseWindow.TabIndex = 3;
            lblCloseWindow.Click += lblCloseWindow_Click;
            // 
            // lblMinimize
            // 
            lblMinimize.Image = Properties.Resources.btnMinimize;
            lblMinimize.Location = new Point(471, 2);
            lblMinimize.Name = "lblMinimize";
            lblMinimize.Size = new Size(22, 13);
            lblMinimize.TabIndex = 4;
            lblMinimize.Click += lblMinimize_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(529, 332);
            Controls.Add(lblMinimize);
            Controls.Add(lblCloseWindow);
            Controls.Add(mainPanel);
            Controls.Add(lblBackground);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label lblBackground;
        private FlowLayoutPanel mainPanel;
        private Label lblCloseWindow;
        private Label lblMinimize;
    }
}