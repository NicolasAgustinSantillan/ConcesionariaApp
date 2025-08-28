using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Ojeda.Concesionario
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

        #region CustomView
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = 20; // radio de esquinas
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            // borde
            using (Pen pen = new Pen(Color.FromArgb(33, 150, 243), 4))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel_ALL = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel_ALL.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel_ALL
            // 
            tableLayoutPanel_ALL.BackColor = SystemColors.Control;
            tableLayoutPanel_ALL.ColumnCount = 2;
            tableLayoutPanel_ALL.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel_ALL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_ALL.Controls.Add(panel1, 0, 0);
            tableLayoutPanel_ALL.Dock = DockStyle.Fill;
            tableLayoutPanel_ALL.Location = new Point(0, 0);
            tableLayoutPanel_ALL.Name = "tableLayoutPanel_ALL";
            tableLayoutPanel_ALL.RowCount = 2;
            tableLayoutPanel_ALL.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel_ALL.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_ALL.Size = new Size(800, 450);
            tableLayoutPanel_ALL.TabIndex = 0;
            // 
            // panel1
            // 
            tableLayoutPanel_ALL.SetColumnSpan(panel1, 2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 38);
            panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel_ALL);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Concesionario";
            Load += MainForm_Load;
            MouseDown += Form_MouseDown;
            tableLayoutPanel_ALL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_ALL;
        private Panel panel1;
    }
}
