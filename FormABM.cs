using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcesionariaApp
{
    public partial class FormABM : Form
    {
        public FormABM()
        {
            InitializeComponent();
        }

        private void FormABM_Load(object sender, EventArgs e)
        {
            rbAlta.Checked = true; 
            ConfigurarAccion();
        }

        private void ConfigurarAccion()
        {
            // Habilitar todos los textbox por defecto
            foreach (Control c in gbDatosVehiculo.Controls)
            {
                if (c is TextBox) c.Enabled = true;
                if (c is DateTimePicker) c.Enabled = true;
            }

            // Si es Modificar → no se puede cambiar el código
            if (rbModificar.Checked)
            {
                txtCodigo.Enabled = false;
            }

            // Si es Baja lógica o definitiva → no se puede modificar nada
            if (rbEliminarLogico.Checked || rbEliminarDef.Checked)
            {
                foreach (Control c in gbDatosVehiculo.Controls)
                {
                    if (c is TextBox) c.Enabled = false;
                    if (c is DateTimePicker) c.Enabled = false;
                }
                txtCodigo.Enabled = true; // se necesita para buscar el vehículo
            }

            // Si es Alta → todos los campos habilitados
            if (rbAlta.Checked)
            {
                foreach (Control c in gbDatosVehiculo.Controls)
                {
                    if (c is TextBox) c.Enabled = true;
                    if (c is DateTimePicker) c.Enabled = true;
                }
            }
        }

        private void rbAlta_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarAccion();
        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarAccion();
        }

        private void rbEliminarLogico_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarAccion();
        }

        private void rbEliminarDef_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarAccion();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbAlta.Checked) AltaVehiculo();
            else if (rbModificar.Checked) ModificarVehiculo();
            else if (rbEliminarLogico.Checked) BajaLogica();
            else if (rbEliminarDef.Checked) BajaDefinitiva();
        }
        private void AltaVehiculo()
        {
            // Validar que no exista el código
            string check = "SELECT COUNT(*) FROM Vehiculos WHERE Vehiculo_Codigo=@cod";
            SqlParameter[] pCheck = { new SqlParameter("@cod", txtCodigo.Text) };
            DataTable dt = DBHelper.GetTable(check.Replace("COUNT(*)", "*")); // rápida
            if (dt.Rows.Count > 0) { MessageBox.Show("Código ya existe!"); return; }

            string query = @"INSERT INTO Vehiculos (Vehiculo_Codigo,Vehiculo_Tipo,Vehiculo_Marca,Vehiculo_Modelo,Vehiculo_Año, Vehiculo_Caracteristicas,Vehiculo_Patente,Vehiculo_Condicion,Vehiculo_Kilometraje,Vehiculo_Precio,Vehiculo_Ingreso) VALUES(@Codigo,@Tipo,@Marca,@Modelo,@Anio,@Carac,@Patente,@Cond,@KM,@Precio,@Ingreso)";
            SqlParameter[] p = {
                new SqlParameter("@Codigo", txtCodigo.Text),
                new SqlParameter("@Tipo", txtTipo.Text),
                new SqlParameter("@Marca", txtMarca.Text),
                new SqlParameter("@Modelo", txtModelo.Text),
                new SqlParameter("@Anio", int.Parse(txtAnio.Text)),
                new SqlParameter("@Carac", txtCarac.Text),
                new SqlParameter("@Patente", txtPatente.Text),
                new SqlParameter("@Cond", txtCondicion.Text),
                new SqlParameter("@KM", int.Parse(txtKM.Text)),
                new SqlParameter("@Precio", decimal.Parse(txtPrecio.Text)),
                new SqlParameter("@Ingreso", dtpIngreso.Value)
            };

            DBHelper.Execute(query, p);
            MessageBox.Show("Vehículo agregado!");
        }
        private void ModificarVehiculo()
        {
            string query = @"UPDATE Vehiculos SET Vehiculo_Tipo=@Tipo, Vehiculo_Marca=@Marca, Vehiculo_Modelo=@Modelo,Vehiculo_Año=@Anio, Vehiculo_Caracteristicas=@Carac, Vehiculo_Patente=@Patente, Vehiculo_Condicion=@Cond, Vehiculo_Kilometraje=@KM, Vehiculo_Precio=@Precio, Vehiculo_Ingreso=@Ingreso WHERE Vehiculo_Codigo=@Codigo"; // no se puede modificar código

            SqlParameter[] p = {
                    new SqlParameter("@Codigo", txtCodigo.Text),
                    new SqlParameter("@Tipo", txtTipo.Text),
                    new SqlParameter("@Marca", txtMarca.Text),
                    new SqlParameter("@Modelo", txtModelo.Text),
                    new SqlParameter("@Anio", int.Parse(txtAnio.Text)),
                    new SqlParameter("@Carac", txtCarac.Text),
                    new SqlParameter("@Patente", txtPatente.Text),
                    new SqlParameter("@Cond", txtCondicion.Text),
                    new SqlParameter("@KM", int.Parse(txtKM.Text)),
                    new SqlParameter("@Precio", decimal.Parse(txtPrecio.Text)),
                    new SqlParameter("@Ingreso", dtpIngreso.Value)
            };

            DBHelper.Execute(query, p);
            MessageBox.Show("Vehículo modificado!");
        }

        private void BajaLogica()
        {
            string query = "UPDATE Vehiculos SET Vehiculo_Condicion='No Disponible' WHERE Vehiculo_Codigo=@Codigo";
            SqlParameter[] p = { new SqlParameter("@Codigo", txtCodigo.Text) };
            DBHelper.Execute(query, p);
            MessageBox.Show("Vehículo dado de baja (lógica)!");
        }

        private void BajaDefinitiva()
        {
            string query = "DELETE FROM Vehiculos WHERE Vehiculo_Codigo=@Codigo";
            SqlParameter[] p = { new SqlParameter("@Codigo", txtCodigo.Text) };
            DBHelper.Execute(query, p);
            MessageBox.Show("Vehículo eliminado!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Vehiculos WHERE Vehiculo_Codigo=@Codigo";
            SqlParameter[] p = { new SqlParameter("@Codigo", txtCodigo.Text) };
            DataTable dt = DBHelper.GetTable(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtTipo.Text = row["Vehiculo_Tipo"].ToString();
                txtMarca.Text = row["Vehiculo_Marca"].ToString();
                txtModelo.Text = row["Vehiculo_Modelo"].ToString();
                txtAnio.Text = row["Vehiculo_Año"].ToString();
                txtCarac.Text = row["Vehiculo_Caracteristicas"].ToString();
                txtPatente.Text = row["Vehiculo_Patente"].ToString();
                txtCondicion.Text = row["Vehiculo_Condicion"].ToString();
                txtKM.Text = row["Vehiculo_Kilometraje"].ToString();
                txtPrecio.Text = row["Vehiculo_Precio"].ToString();
                dtpIngreso.Value = Convert.ToDateTime(row["Vehiculo_Ingreso"]);
            }
            else
            {
                MessageBox.Show("No se encontró un vehículo con ese código");
            }
        }
    }
}
