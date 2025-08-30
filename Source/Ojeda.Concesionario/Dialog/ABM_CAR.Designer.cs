namespace Ojeda.Concesionario.Dialog
{
    partial class ABM_CAR
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
            lbl_title = new Label();
            btn_accept = new MaterialSkin.Controls.MaterialButton();
            btn_cancel = new MaterialSkin.Controls.MaterialButton();
            cmb_year = new MaterialSkin.Controls.MaterialComboBox();
            txt_code = new MaterialSkin.Controls.MaterialTextBox2();
            txt_kilometers = new MaterialSkin.Controls.MaterialTextBox2();
            txt_price = new MaterialSkin.Controls.MaterialTextBox2();
            txt_description = new MaterialSkin.Controls.MaterialTextBox2();
            txt_patent = new MaterialSkin.Controls.MaterialTextBox2();
            txt_brand = new MaterialSkin.Controls.MaterialTextBox2();
            txt_type = new MaterialSkin.Controls.MaterialTextBox2();
            txt_model = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_code = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lbl_title, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_accept, 2, 11);
            tableLayoutPanel1.Controls.Add(btn_cancel, 3, 11);
            tableLayoutPanel1.Controls.Add(cmb_year, 1, 7);
            tableLayoutPanel1.Controls.Add(txt_code, 1, 1);
            tableLayoutPanel1.Controls.Add(txt_kilometers, 1, 4);
            tableLayoutPanel1.Controls.Add(txt_price, 1, 5);
            tableLayoutPanel1.Controls.Add(txt_description, 1, 8);
            tableLayoutPanel1.Controls.Add(txt_patent, 1, 9);
            tableLayoutPanel1.Controls.Add(txt_brand, 1, 2);
            tableLayoutPanel1.Controls.Add(txt_type, 1, 6);
            tableLayoutPanel1.Controls.Add(txt_model, 1, 3);
            tableLayoutPanel1.Controls.Add(lbl_code, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 7);
            tableLayoutPanel1.Controls.Add(label7, 0, 8);
            tableLayoutPanel1.Controls.Add(label8, 0, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090085F));
            tableLayoutPanel1.Size = new Size(1109, 796);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.BackColor = Color.FromArgb(63, 81, 181);
            tableLayoutPanel1.SetColumnSpan(lbl_title, 4);
            lbl_title.Dock = DockStyle.Fill;
            lbl_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.White;
            lbl_title.Location = new Point(3, 15);
            lbl_title.Margin = new Padding(3, 15, 3, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(1103, 65);
            lbl_title.TabIndex = 2;
            lbl_title.Text = ".";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_accept
            // 
            btn_accept.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_accept.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_accept.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_accept.Depth = 0;
            btn_accept.HighEmphasis = true;
            btn_accept.Icon = null;
            btn_accept.Location = new Point(558, 745);
            btn_accept.Margin = new Padding(4, 6, 4, 6);
            btn_accept.MouseState = MaterialSkin.MouseState.HOVER;
            btn_accept.Name = "btn_accept";
            btn_accept.NoAccentTextColor = Color.Empty;
            btn_accept.Size = new Size(269, 36);
            btn_accept.TabIndex = 1;
            btn_accept.Text = "Crear";
            btn_accept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_accept.UseAccentColor = false;
            btn_accept.UseVisualStyleBackColor = true;
            btn_accept.Click += btn_accept_click;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_cancel.Depth = 0;
            btn_cancel.HighEmphasis = true;
            btn_cancel.Icon = null;
            btn_cancel.Location = new Point(835, 745);
            btn_cancel.Margin = new Padding(4, 6, 4, 6);
            btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            btn_cancel.Name = "btn_cancel";
            btn_cancel.NoAccentTextColor = Color.Empty;
            btn_cancel.Size = new Size(270, 36);
            btn_cancel.TabIndex = 0;
            btn_cancel.Text = "Cancelar";
            btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_cancel.UseAccentColor = false;
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // cmb_year
            // 
            cmb_year.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmb_year.AutoResize = false;
            cmb_year.BackColor = Color.FromArgb(255, 255, 255);
            cmb_year.Depth = 0;
            cmb_year.DrawMode = DrawMode.OwnerDrawVariable;
            cmb_year.DropDownHeight = 174;
            cmb_year.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_year.DropDownWidth = 121;
            cmb_year.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmb_year.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmb_year.FormattingEnabled = true;
            cmb_year.IntegralHeight = false;
            cmb_year.ItemHeight = 43;
            cmb_year.Location = new Point(287, 480);
            cmb_year.Margin = new Padding(10);
            cmb_year.MaxDropDownItems = 4;
            cmb_year.MouseState = MaterialSkin.MouseState.OUT;
            cmb_year.Name = "cmb_year";
            cmb_year.Size = new Size(257, 49);
            cmb_year.StartIndex = 0;
            cmb_year.TabIndex = 7;
            // 
            // txt_code
            // 
            txt_code.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_code.AnimateReadOnly = false;
            txt_code.BackgroundImageLayout = ImageLayout.None;
            txt_code.CharacterCasing = CharacterCasing.Normal;
            txt_code.Depth = 0;
            txt_code.Enabled = false;
            txt_code.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_code.HideSelection = true;
            txt_code.LeadingIcon = null;
            txt_code.Location = new Point(280, 88);
            txt_code.MaxLength = 32767;
            txt_code.MouseState = MaterialSkin.MouseState.OUT;
            txt_code.Name = "txt_code";
            txt_code.PasswordChar = '\0';
            txt_code.PrefixSuffixText = null;
            txt_code.ReadOnly = false;
            txt_code.RightToLeft = RightToLeft.No;
            txt_code.SelectedText = "";
            txt_code.SelectionLength = 0;
            txt_code.SelectionStart = 0;
            txt_code.ShortcutsEnabled = true;
            txt_code.Size = new Size(271, 48);
            txt_code.TabIndex = 9;
            txt_code.TabStop = false;
            txt_code.TextAlign = HorizontalAlignment.Left;
            txt_code.TrailingIcon = null;
            txt_code.UseSystemPasswordChar = false;
            // 
            // txt_kilometers
            // 
            txt_kilometers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_kilometers.AnimateReadOnly = false;
            txt_kilometers.BackgroundImageLayout = ImageLayout.None;
            txt_kilometers.CharacterCasing = CharacterCasing.Normal;
            txt_kilometers.Depth = 0;
            txt_kilometers.ErrorMessage = "Ingresar valor numerico !!";
            txt_kilometers.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_kilometers.HelperText = "23145";
            txt_kilometers.HideSelection = true;
            txt_kilometers.LeadingIcon = null;
            txt_kilometers.Location = new Point(280, 278);
            txt_kilometers.MaxLength = 32767;
            txt_kilometers.MouseState = MaterialSkin.MouseState.OUT;
            txt_kilometers.Name = "txt_kilometers";
            txt_kilometers.PasswordChar = '\0';
            txt_kilometers.PrefixSuffixText = null;
            txt_kilometers.ReadOnly = false;
            txt_kilometers.RightToLeft = RightToLeft.No;
            txt_kilometers.SelectedText = "";
            txt_kilometers.SelectionLength = 0;
            txt_kilometers.SelectionStart = 0;
            txt_kilometers.ShortcutsEnabled = true;
            txt_kilometers.ShowAssistiveText = true;
            txt_kilometers.Size = new Size(271, 64);
            txt_kilometers.TabIndex = 10;
            txt_kilometers.TabStop = false;
            txt_kilometers.TextAlign = HorizontalAlignment.Left;
            txt_kilometers.TrailingIcon = null;
            txt_kilometers.UseSystemPasswordChar = false;
            // 
            // txt_price
            // 
            txt_price.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_price.AnimateReadOnly = false;
            txt_price.BackgroundImageLayout = ImageLayout.None;
            txt_price.CharacterCasing = CharacterCasing.Normal;
            txt_price.Depth = 0;
            txt_price.ErrorMessage = "Ingresar valor numerico !!";
            txt_price.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_price.HelperText = "20000000";
            txt_price.HideSelection = true;
            txt_price.LeadingIcon = null;
            txt_price.Location = new Point(280, 343);
            txt_price.MaxLength = 32767;
            txt_price.MouseState = MaterialSkin.MouseState.OUT;
            txt_price.Name = "txt_price";
            txt_price.PasswordChar = '\0';
            txt_price.PrefixSuffixText = null;
            txt_price.ReadOnly = false;
            txt_price.RightToLeft = RightToLeft.No;
            txt_price.SelectedText = "";
            txt_price.SelectionLength = 0;
            txt_price.SelectionStart = 0;
            txt_price.ShortcutsEnabled = true;
            txt_price.ShowAssistiveText = true;
            txt_price.Size = new Size(271, 64);
            txt_price.TabIndex = 11;
            txt_price.TabStop = false;
            txt_price.TextAlign = HorizontalAlignment.Left;
            txt_price.TrailingIcon = null;
            txt_price.UseSystemPasswordChar = false;
            // 
            // txt_description
            // 
            txt_description.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_description.AnimateReadOnly = false;
            txt_description.BackgroundImageLayout = ImageLayout.None;
            txt_description.CharacterCasing = CharacterCasing.Normal;
            txt_description.Depth = 0;
            txt_description.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_description.HideSelection = true;
            txt_description.LeadingIcon = null;
            txt_description.Location = new Point(280, 538);
            txt_description.MaxLength = 32767;
            txt_description.MouseState = MaterialSkin.MouseState.OUT;
            txt_description.Name = "txt_description";
            txt_description.PasswordChar = '\0';
            txt_description.PrefixSuffixText = null;
            txt_description.ReadOnly = false;
            txt_description.RightToLeft = RightToLeft.No;
            txt_description.SelectedText = "";
            txt_description.SelectionLength = 0;
            txt_description.SelectionStart = 0;
            txt_description.ShortcutsEnabled = true;
            txt_description.ShowAssistiveText = true;
            txt_description.Size = new Size(271, 64);
            txt_description.TabIndex = 12;
            txt_description.TabStop = false;
            txt_description.TextAlign = HorizontalAlignment.Left;
            txt_description.TrailingIcon = null;
            txt_description.UseSystemPasswordChar = false;
            // 
            // txt_patent
            // 
            txt_patent.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_patent.AnimateReadOnly = false;
            txt_patent.BackgroundImageLayout = ImageLayout.None;
            txt_patent.CharacterCasing = CharacterCasing.Normal;
            txt_patent.Depth = 0;
            txt_patent.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_patent.HelperText = "ACD312, AS 132 DE";
            txt_patent.HideSelection = true;
            txt_patent.LeadingIcon = null;
            txt_patent.Location = new Point(280, 603);
            txt_patent.MaxLength = 32767;
            txt_patent.MouseState = MaterialSkin.MouseState.OUT;
            txt_patent.Name = "txt_patent";
            txt_patent.PasswordChar = '\0';
            txt_patent.PrefixSuffixText = null;
            txt_patent.ReadOnly = false;
            txt_patent.RightToLeft = RightToLeft.No;
            txt_patent.SelectedText = "";
            txt_patent.SelectionLength = 0;
            txt_patent.SelectionStart = 0;
            txt_patent.ShortcutsEnabled = true;
            txt_patent.ShowAssistiveText = true;
            txt_patent.Size = new Size(271, 64);
            txt_patent.TabIndex = 13;
            txt_patent.TabStop = false;
            txt_patent.TextAlign = HorizontalAlignment.Left;
            txt_patent.TrailingIcon = null;
            txt_patent.UseSystemPasswordChar = false;
            // 
            // txt_brand
            // 
            txt_brand.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_brand.AnimateReadOnly = false;
            txt_brand.BackgroundImageLayout = ImageLayout.None;
            txt_brand.CharacterCasing = CharacterCasing.Normal;
            txt_brand.Depth = 0;
            txt_brand.ErrorMessage = "Completar campo !!";
            txt_brand.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_brand.HelperText = "Toyota, Suzuki, Honda ..";
            txt_brand.HideSelection = true;
            txt_brand.LeadingIcon = null;
            txt_brand.Location = new Point(280, 148);
            txt_brand.MaxLength = 32767;
            txt_brand.MouseState = MaterialSkin.MouseState.OUT;
            txt_brand.Name = "txt_brand";
            txt_brand.PasswordChar = '\0';
            txt_brand.PrefixSuffixText = null;
            txt_brand.ReadOnly = false;
            txt_brand.RightToLeft = RightToLeft.No;
            txt_brand.SelectedText = "";
            txt_brand.SelectionLength = 0;
            txt_brand.SelectionStart = 0;
            txt_brand.ShortcutsEnabled = true;
            txt_brand.ShowAssistiveText = true;
            txt_brand.Size = new Size(271, 64);
            txt_brand.TabIndex = 15;
            txt_brand.TabStop = false;
            txt_brand.TextAlign = HorizontalAlignment.Left;
            txt_brand.TrailingIcon = null;
            txt_brand.UseSystemPasswordChar = false;
            // 
            // txt_type
            // 
            txt_type.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_type.AnimateReadOnly = false;
            txt_type.BackgroundImageLayout = ImageLayout.None;
            txt_type.CharacterCasing = CharacterCasing.Normal;
            txt_type.Depth = 0;
            txt_type.ErrorMessage = "Completar campo !!";
            txt_type.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_type.HelperText = "SU, Seda, Hatchbac, Pickup, Coupe";
            txt_type.HideSelection = true;
            txt_type.LeadingIcon = null;
            txt_type.Location = new Point(280, 408);
            txt_type.MaxLength = 32767;
            txt_type.MouseState = MaterialSkin.MouseState.OUT;
            txt_type.Name = "txt_type";
            txt_type.PasswordChar = '\0';
            txt_type.PrefixSuffixText = null;
            txt_type.ReadOnly = false;
            txt_type.RightToLeft = RightToLeft.No;
            txt_type.SelectedText = "";
            txt_type.SelectionLength = 0;
            txt_type.SelectionStart = 0;
            txt_type.ShortcutsEnabled = true;
            txt_type.ShowAssistiveText = true;
            txt_type.Size = new Size(271, 64);
            txt_type.TabIndex = 16;
            txt_type.TabStop = false;
            txt_type.TextAlign = HorizontalAlignment.Left;
            txt_type.TrailingIcon = null;
            txt_type.UseSystemPasswordChar = false;
            // 
            // txt_model
            // 
            txt_model.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_model.AnimateReadOnly = false;
            txt_model.BackgroundImageLayout = ImageLayout.None;
            txt_model.CharacterCasing = CharacterCasing.Normal;
            txt_model.Depth = 0;
            txt_model.ErrorMessage = "Completar campo !!";
            txt_model.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_model.HelperText = "Corolla, Swift, Civic ...";
            txt_model.HideSelection = true;
            txt_model.LeadingIcon = null;
            txt_model.Location = new Point(280, 213);
            txt_model.MaxLength = 32767;
            txt_model.MouseState = MaterialSkin.MouseState.OUT;
            txt_model.Name = "txt_model";
            txt_model.PasswordChar = '\0';
            txt_model.PrefixSuffixText = null;
            txt_model.ReadOnly = false;
            txt_model.RightToLeft = RightToLeft.No;
            txt_model.SelectedText = "";
            txt_model.SelectionLength = 0;
            txt_model.SelectionStart = 0;
            txt_model.ShortcutsEnabled = true;
            txt_model.ShowAssistiveText = true;
            txt_model.Size = new Size(271, 64);
            txt_model.TabIndex = 17;
            txt_model.TabStop = false;
            txt_model.TextAlign = HorizontalAlignment.Left;
            txt_model.TrailingIcon = null;
            txt_model.UseSystemPasswordChar = false;
            // 
            // lbl_code
            // 
            lbl_code.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_code.AutoSize = true;
            lbl_code.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_code.Location = new Point(3, 100);
            lbl_code.Name = "lbl_code";
            lbl_code.Size = new Size(271, 24);
            lbl_code.TabIndex = 18;
            lbl_code.Text = "Codigo";
            lbl_code.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 165);
            label1.Name = "label1";
            label1.Size = new Size(271, 24);
            label1.TabIndex = 19;
            label1.Text = "Marca";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 230);
            label2.Name = "label2";
            label2.Size = new Size(271, 24);
            label2.TabIndex = 20;
            label2.Text = "Modelo";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 295);
            label3.Name = "label3";
            label3.Size = new Size(271, 24);
            label3.TabIndex = 21;
            label3.Text = "kilometros";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 360);
            label4.Name = "label4";
            label4.Size = new Size(271, 24);
            label4.TabIndex = 22;
            label4.Text = "Precio";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 425);
            label5.Name = "label5";
            label5.Size = new Size(271, 24);
            label5.TabIndex = 23;
            label5.Text = "Tipo";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 490);
            label6.Name = "label6";
            label6.Size = new Size(271, 24);
            label6.TabIndex = 24;
            label6.Text = "Año";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 555);
            label7.Name = "label7";
            label7.Size = new Size(271, 24);
            label7.TabIndex = 25;
            label7.Text = "Descripcion";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 620);
            label8.Name = "label8";
            label8.Size = new Size(271, 24);
            label8.TabIndex = 26;
            label8.Text = "Patente";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ABM_CAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 796);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ABM_CAR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABM_CAR";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btn_accept;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private Label lbl_title;
        private MaterialSkin.Controls.MaterialTextBox2 txt_code;
        private MaterialSkin.Controls.MaterialComboBox cmb_year;
        private MaterialSkin.Controls.MaterialTextBox2 txt_kilometers;
        private MaterialSkin.Controls.MaterialTextBox2 txt_price;
        private MaterialSkin.Controls.MaterialTextBox2 txt_description;
        private MaterialSkin.Controls.MaterialTextBox2 txt_patent;
        private MaterialSkin.Controls.MaterialTextBox2 txt_brand;
        private MaterialSkin.Controls.MaterialTextBox2 txt_type;
        private MaterialSkin.Controls.MaterialTextBox2 txt_model;
        private Label lbl_code;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}