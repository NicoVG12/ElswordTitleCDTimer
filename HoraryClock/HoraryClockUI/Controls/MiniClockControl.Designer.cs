namespace TitleTimerUI.Controls
{
    partial class MiniClockControl
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
            lblCloseWindow = new Label();
            lbl175 = new Label();
            lblBackground = new Label();
            label1 = new Label();
            lbl156 = new Label();
            lbl135 = new Label();
            lblMaximize = new Label();
            lblOrder = new Label();
            SuspendLayout();
            // 
            // lblCloseWindow
            // 
            lblCloseWindow.Image = Properties.Resources.btnMiniClose;
            lblCloseWindow.Location = new Point(160, 2);
            lblCloseWindow.Name = "lblCloseWindow";
            lblCloseWindow.Size = new Size(29, 28);
            lblCloseWindow.TabIndex = 4;
            lblCloseWindow.Click += lblCloseWindow_Click;
            // 
            // lbl175
            // 
            lbl175.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl175.ForeColor = Color.White;
            lbl175.Image = Properties.Resources.Title_175;
            lbl175.Location = new Point(4, 48);
            lbl175.Name = "lbl175";
            lbl175.Size = new Size(45, 45);
            lbl175.TabIndex = 15;
            lbl175.TextAlign = ContentAlignment.MiddleCenter;
            lbl175.Click += lbl175_Click;
            // 
            // lblBackground
            // 
            lblBackground.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBackground.ForeColor = Color.White;
            lblBackground.Image = Properties.Resources.CDTimerbg;
            lblBackground.Location = new Point(0, 0);
            lblBackground.Margin = new Padding(0);
            lblBackground.Name = "lblBackground";
            lblBackground.Padding = new Padding(10);
            lblBackground.Size = new Size(191, 104);
            lblBackground.TabIndex = 19;
            lblBackground.Text = "Title CD Timer v1.0";
            lblBackground.Click += lblBackground_Click;
            lblBackground.MouseDown += lblBackground_MouseDown;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.MiniClockwindow;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(-2, 34);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(188, 74);
            label1.TabIndex = 20;
            label1.Click += label1_Click_1;
            // 
            // lbl156
            // 
            lbl156.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl156.ForeColor = Color.White;
            lbl156.Image = Properties.Resources.Title_1561;
            lbl156.Location = new Point(50, 48);
            lbl156.Name = "lbl156";
            lbl156.Size = new Size(45, 45);
            lbl156.TabIndex = 21;
            lbl156.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl135
            // 
            lbl135.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl135.ForeColor = Color.White;
            lbl135.Image = Properties.Resources.Title_135;
            lbl135.Location = new Point(96, 48);
            lbl135.Name = "lbl135";
            lbl135.Size = new Size(45, 45);
            lbl135.TabIndex = 22;
            lbl135.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaximize
            // 
            lblMaximize.Image = Properties.Resources.btnMaximize;
            lblMaximize.Location = new Point(136, 2);
            lblMaximize.Name = "lblMaximize";
            lblMaximize.Size = new Size(22, 13);
            lblMaximize.TabIndex = 23;
            lblMaximize.Click += lblMaximize_Click_1;
            // 
            // lblOrder
            // 
            lblOrder.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrder.ForeColor = Color.White;
            lblOrder.Image = Properties.Resources.Title_Order;
            lblOrder.Location = new Point(142, 48);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(45, 45);
            lblOrder.TabIndex = 24;
            lblOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MiniClockControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lblOrder);
            Controls.Add(lblMaximize);
            Controls.Add(lbl135);
            Controls.Add(lbl156);
            Controls.Add(lbl175);
            Controls.Add(lblCloseWindow);
            Controls.Add(label1);
            Controls.Add(lblBackground);
            Margin = new Padding(0);
            Name = "MiniClockControl";
            Size = new Size(191, 104);
            ResumeLayout(false);
        }

        #endregion

        private Label lblCloseWindow;
        private Label lbl175;
        private Label lblBackground;
        private Label label1;
        private Label lbl156;
        private Label lbl135;
        private Label lblMaximize;
        private Label lblOrder;
    }
}
