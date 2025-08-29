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
        int radius = 15;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using var path = RoundedRect(new Rectangle(0, 0, ClientSize.Width, ClientSize.Height), radius);
            this.Region = new Region(path);  // actualiza región al cambiar tamaño
            Invalidate();                    // repinta borde
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var path = RoundedRect(new Rectangle(0, 0, ClientSize.Width - 1, ClientSize.Height - 1), radius);
            using var pen = new Pen(Color.FromArgb(33, 150, 243), 2);
            e.Graphics.DrawPath(pen, path);
        }

        GraphicsPath RoundedRect(Rectangle r, int rad)
        {
            int d = rad * 2;
            var gp = new GraphicsPath();
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            gp.CloseFigure();
            return gp;
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
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTLEFT = 10, HTRIGHT = 11, HTTOP = 12, HTTOPLEFT = 13, HTTOPRIGHT = 14,
                      HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                // coordenadas del mouse desde el mensaje (más preciso que Cursor.Position)
                int x = (short)((int)m.LParam & 0xFFFF);
                int y = (short)(((int)m.LParam >> 16) & 0xFFFF);
                Point pos = PointToClient(new Point(x, y));

                int grip = this.Padding.Left; // usamos el mismo valor del padding

                bool left = pos.X <= grip;
                bool right = pos.X >= ClientSize.Width - grip;
                bool top = pos.Y <= grip;
                bool bottom = pos.Y >= ClientSize.Height - grip;

                if (left && top) { m.Result = (IntPtr)HTTOPLEFT; return; }
                if (right && top) { m.Result = (IntPtr)HTTOPRIGHT; return; }
                if (left && bottom) { m.Result = (IntPtr)HTBOTTOMLEFT; return; }
                if (right && bottom) { m.Result = (IntPtr)HTBOTTOMRIGHT; return; }
                if (left) { m.Result = (IntPtr)HTLEFT; return; }
                if (right) { m.Result = (IntPtr)HTRIGHT; return; }
                if (top) { m.Result = (IntPtr)HTTOP; return; }
                if (bottom) { m.Result = (IntPtr)HTBOTTOM; return; }
            }

            base.WndProc(ref m);
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
            panel_top = new Panel();
            btn_close = new MaterialSkin.Controls.MaterialButton();
            btn_minimize = new MaterialSkin.Controls.MaterialButton();
            panel_left = new Panel();
            panel_main = new Panel();
            tableLayoutPanel_ALL.SuspendLayout();
            panel_top.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel_ALL
            // 
            tableLayoutPanel_ALL.BackColor = Color.FromArgb(242, 246, 252);
            tableLayoutPanel_ALL.ColumnCount = 2;
            tableLayoutPanel_ALL.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel_ALL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_ALL.Controls.Add(panel_top, 0, 0);
            tableLayoutPanel_ALL.Controls.Add(panel_left, 0, 1);
            tableLayoutPanel_ALL.Controls.Add(panel_main, 1, 1);
            tableLayoutPanel_ALL.Dock = DockStyle.Fill;
            tableLayoutPanel_ALL.Location = new Point(0, 0);
            tableLayoutPanel_ALL.Margin = new Padding(10);
            tableLayoutPanel_ALL.Name = "tableLayoutPanel_ALL";
            tableLayoutPanel_ALL.RowCount = 2;
            tableLayoutPanel_ALL.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel_ALL.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_ALL.Size = new Size(1200, 600);
            tableLayoutPanel_ALL.TabIndex = 0;
            tableLayoutPanel_ALL.MouseDown += Form_MouseDown;
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.FromArgb(242, 246, 252);
            tableLayoutPanel_ALL.SetColumnSpan(panel_top, 2);
            panel_top.Controls.Add(btn_close);
            panel_top.Controls.Add(btn_minimize);
            panel_top.Dock = DockStyle.Fill;
            panel_top.Location = new Point(2, 2);
            panel_top.Margin = new Padding(2);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1196, 36);
            panel_top.TabIndex = 0;
            panel_top.MouseDown += Form_MouseDown;
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_close.BackColor = Color.FromArgb(244, 67, 54);
            btn_close.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_close.Depth = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.ForeColor = Color.White;
            btn_close.HighEmphasis = true;
            btn_close.Icon = null;
            btn_close.Location = new Point(1131, 0);
            btn_close.Margin = new Padding(4, 6, 4, 6);
            btn_close.MouseState = MaterialSkin.MouseState.HOVER;
            btn_close.Name = "btn_close";
            btn_close.NoAccentTextColor = Color.Empty;
            btn_close.Size = new Size(64, 36);
            btn_close.TabIndex = 0;
            btn_close.Text = "x";
            btn_close.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_close.UseAccentColor = false;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_minimize.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_minimize.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_minimize.Depth = 0;
            btn_minimize.HighEmphasis = true;
            btn_minimize.Icon = null;
            btn_minimize.Location = new Point(1059, 0);
            btn_minimize.Margin = new Padding(4, 6, 4, 6);
            btn_minimize.MouseState = MaterialSkin.MouseState.HOVER;
            btn_minimize.Name = "btn_minimize";
            btn_minimize.NoAccentTextColor = Color.Empty;
            btn_minimize.Size = new Size(64, 36);
            btn_minimize.TabIndex = 1;
            btn_minimize.Text = "-";
            btn_minimize.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_minimize.UseAccentColor = false;
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.FromArgb(233, 238, 246);
            panel_left.Dock = DockStyle.Fill;
            panel_left.Location = new Point(5, 45);
            panel_left.Margin = new Padding(5);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(190, 550);
            panel_left.TabIndex = 1;
            panel_left.MouseDown += Form_MouseDown;
            // 
            // panel_main
            // 
            panel_main.AutoSize = true;
            panel_main.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_main.BackColor = Color.White;
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(203, 43);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(994, 554);
            panel_main.TabIndex = 2;
            panel_main.MouseDown += Form_MouseDown;
            panel_main.Resize += panel_main_Resize;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 246, 252);
            ClientSize = new Size(1200, 600);
            Controls.Add(tableLayoutPanel_ALL);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Concesionario";
            Load += MainForm_Load;
            MouseDown += Form_MouseDown;
            tableLayoutPanel_ALL.ResumeLayout(false);
            tableLayoutPanel_ALL.PerformLayout();
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_ALL;
        private Panel panel_top;
        private Panel panel_left;
        private Panel panel_main;
        private MaterialSkin.Controls.MaterialButton btn_close;
        private MaterialSkin.Controls.MaterialButton btn_minimize;
    }
}
