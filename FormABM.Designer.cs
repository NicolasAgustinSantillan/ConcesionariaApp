namespace ConcesionariaApp
{
    partial class FormABM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEliminarDef = new System.Windows.Forms.RadioButton();
            this.rbEliminarLogico = new System.Windows.Forms.RadioButton();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbAlta = new System.Windows.Forms.RadioButton();
            this.gbDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtCarac = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbDatosVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEliminarDef);
            this.groupBox1.Controls.Add(this.rbEliminarLogico);
            this.groupBox1.Controls.Add(this.rbModificar);
            this.groupBox1.Controls.Add(this.rbAlta);
            this.groupBox1.Location = new System.Drawing.Point(30, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accion";
            // 
            // rbEliminarDef
            // 
            this.rbEliminarDef.AutoSize = true;
            this.rbEliminarDef.Location = new System.Drawing.Point(558, 42);
            this.rbEliminarDef.Name = "rbEliminarDef";
            this.rbEliminarDef.Size = new System.Drawing.Size(91, 17);
            this.rbEliminarDef.TabIndex = 3;
            this.rbEliminarDef.TabStop = true;
            this.rbEliminarDef.Text = "Baja definitiva";
            this.rbEliminarDef.UseVisualStyleBackColor = true;
            this.rbEliminarDef.CheckedChanged += new System.EventHandler(this.rbEliminarDef_CheckedChanged);
            // 
            // rbEliminarLogico
            // 
            this.rbEliminarLogico.AutoSize = true;
            this.rbEliminarLogico.Location = new System.Drawing.Point(397, 42);
            this.rbEliminarLogico.Name = "rbEliminarLogico";
            this.rbEliminarLogico.Size = new System.Drawing.Size(77, 17);
            this.rbEliminarLogico.TabIndex = 2;
            this.rbEliminarLogico.TabStop = true;
            this.rbEliminarLogico.Text = "Baja lógica";
            this.rbEliminarLogico.UseVisualStyleBackColor = true;
            this.rbEliminarLogico.CheckedChanged += new System.EventHandler(this.rbEliminarLogico_CheckedChanged);
            // 
            // rbModificar
            // 
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(209, 42);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(68, 17);
            this.rbModificar.TabIndex = 1;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.rbModificar_CheckedChanged);
            // 
            // rbAlta
            // 
            this.rbAlta.AutoSize = true;
            this.rbAlta.Location = new System.Drawing.Point(46, 42);
            this.rbAlta.Name = "rbAlta";
            this.rbAlta.Size = new System.Drawing.Size(43, 17);
            this.rbAlta.TabIndex = 0;
            this.rbAlta.TabStop = true;
            this.rbAlta.Text = "Alta";
            this.rbAlta.UseVisualStyleBackColor = true;
            this.rbAlta.CheckedChanged += new System.EventHandler(this.rbAlta_CheckedChanged);
            // 
            // gbDatosVehiculo
            // 
            this.gbDatosVehiculo.Controls.Add(this.btnBuscar);
            this.gbDatosVehiculo.Controls.Add(this.dtpIngreso);
            this.gbDatosVehiculo.Controls.Add(this.txtCarac);
            this.gbDatosVehiculo.Controls.Add(this.txtKM);
            this.gbDatosVehiculo.Controls.Add(this.txtPatente);
            this.gbDatosVehiculo.Controls.Add(this.txtModelo);
            this.gbDatosVehiculo.Controls.Add(this.txtTipo);
            this.gbDatosVehiculo.Controls.Add(this.txtPrecio);
            this.gbDatosVehiculo.Controls.Add(this.txtCondicion);
            this.gbDatosVehiculo.Controls.Add(this.txtAnio);
            this.gbDatosVehiculo.Controls.Add(this.txtMarca);
            this.gbDatosVehiculo.Controls.Add(this.txtCodigo);
            this.gbDatosVehiculo.Controls.Add(this.label11);
            this.gbDatosVehiculo.Controls.Add(this.label10);
            this.gbDatosVehiculo.Controls.Add(this.label9);
            this.gbDatosVehiculo.Controls.Add(this.label8);
            this.gbDatosVehiculo.Controls.Add(this.label7);
            this.gbDatosVehiculo.Controls.Add(this.label6);
            this.gbDatosVehiculo.Controls.Add(this.label5);
            this.gbDatosVehiculo.Controls.Add(this.label4);
            this.gbDatosVehiculo.Controls.Add(this.label3);
            this.gbDatosVehiculo.Controls.Add(this.label2);
            this.gbDatosVehiculo.Controls.Add(this.label1);
            this.gbDatosVehiculo.Location = new System.Drawing.Point(30, 160);
            this.gbDatosVehiculo.Name = "gbDatosVehiculo";
            this.gbDatosVehiculo.Size = new System.Drawing.Size(704, 328);
            this.gbDatosVehiculo.TabIndex = 12;
            this.gbDatosVehiculo.TabStop = false;
            this.gbDatosVehiculo.Text = "Datos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(305, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(472, 199);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(214, 20);
            this.dtpIngreso.TabIndex = 34;
            // 
            // txtCarac
            // 
            this.txtCarac.Location = new System.Drawing.Point(119, 261);
            this.txtCarac.MaxLength = 100;
            this.txtCarac.Name = "txtCarac";
            this.txtCarac.Size = new System.Drawing.Size(520, 20);
            this.txtCarac.TabIndex = 33;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(472, 160);
            this.txtKM.MaxLength = 10;
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(214, 20);
            this.txtKM.TabIndex = 31;
            this.txtKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKM_KeyPress);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(472, 124);
            this.txtPatente.MaxLength = 10;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(214, 20);
            this.txtPatente.TabIndex = 30;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(472, 90);
            this.txtModelo.MaxLength = 50;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(214, 20);
            this.txtModelo.TabIndex = 29;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(472, 46);
            this.txtTipo.MaxLength = 50;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(214, 20);
            this.txtTipo.TabIndex = 28;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(74, 199);
            this.txtPrecio.MaxLength = 15;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(214, 20);
            this.txtPrecio.TabIndex = 27;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(74, 160);
            this.txtCondicion.MaxLength = 50;
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(214, 20);
            this.txtCondicion.TabIndex = 26;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(74, 124);
            this.txtAnio.MaxLength = 8;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(214, 20);
            this.txtAnio.TabIndex = 25;
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(74, 90);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(214, 20);
            this.txtMarca.TabIndex = 24;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(74, 49);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(214, 20);
            this.txtCodigo.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Características:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(419, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ingreso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "KM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Patente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = " Modelo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Condición:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(578, 508);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 33);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(455, 508);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 33);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbDatosVehiculo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormABM";
            this.Text = "FormABM";
            this.Load += new System.EventHandler(this.FormABM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatosVehiculo.ResumeLayout(false);
            this.gbDatosVehiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEliminarDef;
        private System.Windows.Forms.RadioButton rbEliminarLogico;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbAlta;
        private System.Windows.Forms.GroupBox gbDatosVehiculo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarac;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
    }
}