namespace ConcesionariaApp
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbNuevos = new System.Windows.Forms.RadioButton();
            this.rbUsados = new System.Windows.Forms.RadioButton();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnABM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUsados);
            this.groupBox1.Controls.Add(this.rbNuevos);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Location = new System.Drawing.Point(58, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(83, 42);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbNuevos
            // 
            this.rbNuevos.AutoSize = true;
            this.rbNuevos.Location = new System.Drawing.Point(301, 42);
            this.rbNuevos.Name = "rbNuevos";
            this.rbNuevos.Size = new System.Drawing.Size(62, 17);
            this.rbNuevos.TabIndex = 1;
            this.rbNuevos.TabStop = true;
            this.rbNuevos.Text = "Nuevos";
            this.rbNuevos.UseVisualStyleBackColor = true;
            this.rbNuevos.CheckedChanged += new System.EventHandler(this.rbNuevos_CheckedChanged);
            // 
            // rbUsados
            // 
            this.rbUsados.AutoSize = true;
            this.rbUsados.Location = new System.Drawing.Point(541, 42);
            this.rbUsados.Name = "rbUsados";
            this.rbUsados.Size = new System.Drawing.Size(61, 17);
            this.rbUsados.TabIndex = 2;
            this.rbUsados.TabStop = true;
            this.rbUsados.Text = "Usados";
            this.rbUsados.UseVisualStyleBackColor = true;
            this.rbUsados.CheckedChanged += new System.EventHandler(this.rbUsados_CheckedChanged);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(58, 150);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(687, 256);
            this.dgvVehiculos.TabIndex = 1;
            // 
            // btnABM
            // 
            this.btnABM.Location = new System.Drawing.Point(599, 443);
            this.btnABM.Name = "btnABM";
            this.btnABM.Size = new System.Drawing.Size(123, 41);
            this.btnABM.TabIndex = 2;
            this.btnABM.Text = "Gestion de vehiculos";
            this.btnABM.UseVisualStyleBackColor = true;
            this.btnABM.Click += new System.EventHandler(this.btnABM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnABM);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUsados;
        private System.Windows.Forms.RadioButton rbNuevos;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnABM;
    }
}

