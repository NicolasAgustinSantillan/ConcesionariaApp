namespace Ojeda.Concesionario.View
{
    partial class CarListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dgv_cars = new DataGridView();
            btn_newcar = new MaterialSkin.Controls.MaterialButton();
            txt_search = new MaterialSkin.Controls.MaterialTextBox2();
            btn_search = new MaterialSkin.Controls.MaterialButton();
            btn_clear = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_cars).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(dgv_cars, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_newcar, 4, 0);
            tableLayoutPanel1.Controls.Add(txt_search, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_search, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_clear, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1000, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(63, 81, 181);
            tableLayoutPanel1.SetColumnSpan(label1, 4);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 65);
            label1.Margin = new Padding(3, 15, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(954, 35);
            label1.TabIndex = 1;
            label1.Text = "Listado de autos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgv_cars
            // 
            dgv_cars.AllowUserToAddRows = false;
            dgv_cars.AllowUserToDeleteRows = false;
            dgv_cars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgv_cars, 4);
            dgv_cars.Dock = DockStyle.Fill;
            dgv_cars.Location = new Point(23, 103);
            dgv_cars.Name = "dgv_cars";
            dgv_cars.ReadOnly = true;
            dgv_cars.Size = new Size(954, 494);
            dgv_cars.TabIndex = 0;
            dgv_cars.CellClick += dgv_cars_CellClick;
            dgv_cars.CellPainting += dgv_cars_CellPainting;
            // 
            // btn_newcar
            // 
            btn_newcar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_newcar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_newcar.Depth = 0;
            btn_newcar.Dock = DockStyle.Right;
            btn_newcar.HighEmphasis = true;
            btn_newcar.Icon = null;
            btn_newcar.Location = new Point(909, 6);
            btn_newcar.Margin = new Padding(4, 6, 4, 6);
            btn_newcar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_newcar.Name = "btn_newcar";
            btn_newcar.NoAccentTextColor = Color.Empty;
            btn_newcar.Size = new Size(67, 38);
            btn_newcar.TabIndex = 2;
            btn_newcar.Text = "Crear";
            btn_newcar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_newcar.UseAccentColor = false;
            btn_newcar.UseVisualStyleBackColor = true;
            btn_newcar.Click += btn_newcar_Click;
            // 
            // txt_search
            // 
            txt_search.AnimateReadOnly = false;
            txt_search.BackgroundImageLayout = ImageLayout.None;
            txt_search.CharacterCasing = CharacterCasing.Normal;
            txt_search.Depth = 0;
            txt_search.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_search.HideSelection = true;
            txt_search.LeadingIcon = null;
            txt_search.Location = new Point(23, 3);
            txt_search.MaxLength = 32767;
            txt_search.MouseState = MaterialSkin.MouseState.OUT;
            txt_search.Name = "txt_search";
            txt_search.PasswordChar = '\0';
            txt_search.PrefixSuffixText = null;
            txt_search.ReadOnly = false;
            txt_search.RightToLeft = RightToLeft.No;
            txt_search.SelectedText = "";
            txt_search.SelectionLength = 0;
            txt_search.SelectionStart = 0;
            txt_search.ShortcutsEnabled = true;
            txt_search.Size = new Size(186, 48);
            txt_search.TabIndex = 3;
            txt_search.TabStop = false;
            txt_search.TextAlign = HorizontalAlignment.Left;
            txt_search.TrailingIcon = null;
            txt_search.UseSystemPasswordChar = false;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_search.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_search.Depth = 0;
            btn_search.HighEmphasis = true;
            btn_search.Icon = null;
            btn_search.Location = new Point(216, 6);
            btn_search.Margin = new Padding(4, 6, 4, 6);
            btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            btn_search.Name = "btn_search";
            btn_search.NoAccentTextColor = Color.Empty;
            btn_search.Size = new Size(184, 36);
            btn_search.TabIndex = 4;
            btn_search.Text = "Buscar";
            btn_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_search.UseAccentColor = false;
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_clear
            // 
            btn_clear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_clear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_clear.Depth = 0;
            btn_clear.HighEmphasis = true;
            btn_clear.Icon = null;
            btn_clear.Location = new Point(408, 6);
            btn_clear.Margin = new Padding(4, 6, 4, 6);
            btn_clear.MouseState = MaterialSkin.MouseState.HOVER;
            btn_clear.Name = "btn_clear";
            btn_clear.NoAccentTextColor = Color.Empty;
            btn_clear.Size = new Size(184, 36);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "Limpiar";
            btn_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_clear.UseAccentColor = false;
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // CarListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarListView";
            Text = "CarList";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_cars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgv_cars;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton btn_newcar;
        private MaterialSkin.Controls.MaterialTextBox2 txt_search;
        private MaterialSkin.Controls.MaterialButton btn_search;
        private MaterialSkin.Controls.MaterialButton btn_clear;
    }
}