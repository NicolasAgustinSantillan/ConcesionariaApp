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
            Cars_ListView = new MaterialSkin.Controls.MaterialListView();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(Cars_ListView, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1000, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Cars_ListView
            // 
            Cars_ListView.AutoSizeTable = false;
            Cars_ListView.BackColor = Color.FromArgb(255, 255, 255);
            Cars_ListView.BorderStyle = BorderStyle.None;
            Cars_ListView.Depth = 0;
            Cars_ListView.Dock = DockStyle.Fill;
            Cars_ListView.FullRowSelect = true;
            Cars_ListView.Location = new Point(23, 53);
            Cars_ListView.MinimumSize = new Size(200, 100);
            Cars_ListView.MouseLocation = new Point(-1, -1);
            Cars_ListView.MouseState = MaterialSkin.MouseState.OUT;
            Cars_ListView.Name = "Cars_ListView";
            Cars_ListView.OwnerDraw = true;
            Cars_ListView.Size = new Size(954, 544);
            Cars_ListView.TabIndex = 0;
            Cars_ListView.UseCompatibleStateImageBehavior = false;
            Cars_ListView.View = System.Windows.Forms.View.Details;
            // 
            // CarList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarList";
            Text = "CarList";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialListView Cars_ListView;
    }
}