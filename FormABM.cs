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
                btnBuscar.Enabled = true;
            }

            // Si es Alta → todos los campos habilitados
            if (rbAlta.Checked)
            {
                foreach (Control c in gbDatosVehiculo.Controls)
                {
                    if (c is TextBox) c.Enabled = true;
                    if (c is DateTimePicker) c.Enabled = true;
                }
                btnBuscar.Enabled = false;
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
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtTipo.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtAnio.Text) ||
                string.IsNullOrWhiteSpace(txtCarac.Text) ||
                string.IsNullOrWhiteSpace(txtPatente.Text) ||
                string.IsNullOrWhiteSpace(txtCondicion.Text) ||
                string.IsNullOrWhiteSpace(txtKM.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("⚠️ Todos los campos son obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salgo del método sin ejecutar el alta
            }

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
            DataTable dt = DBHelper.GetTable(check, pCheck); // ✅ ahora sí se pasa parámetro

            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                MessageBox.Show("Código ya existe!");
                return;
            }

            string query = @"INSERT INTO Vehiculos
        (Vehiculo_Codigo,Vehiculo_Tipo,Vehiculo_Marca,Vehiculo_Modelo,Vehiculo_Año,
         Vehiculo_Caracteristicas,Vehiculo_Patente,Vehiculo_Condicion,Vehiculo_Kilometraje,
         Vehiculo_Precio,Vehiculo_Ingreso)
         VALUES(@Codigo,@Tipo,@Marca,@Modelo,@Anio,@Carac,@Patente,@Cond,@KM,@Precio,@Ingreso)";

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
        private void LimpiarControles(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                if (c is DateTimePicker) ((DateTimePicker)c).Value = DateTime.Now;
                if (c is ComboBox) ((ComboBox)c).SelectedIndex = -1;

                // Si hay más contenedores, limpiar también sus hijos
                if (c.HasChildren)
                    LimpiarControles(c);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtMarca.Clear();
            txtAnio.Clear();
            txtCarac.Clear();
            txtCondicion.Clear();
            txtKM.Clear();
            txtPatente.Clear();
            txtPrecio.Clear();
            txtTipo.Clear();
            txtModelo.Clear();
            
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código de vehículo antes de buscar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(DBHelper.connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Vehiculos WHERE Vehiculo_Codigo=@Codigo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                        txtTipo.Text = reader["Vehiculo_Tipo"].ToString();
                        txtMarca.Text = reader["Vehiculo_Marca"].ToString();
                        txtModelo.Text = reader["Vehiculo_Modelo"].ToString();
                        txtAnio.Text = reader["Vehiculo_Año"].ToString();
                        txtCarac.Text = reader["Vehiculo_Caracteristicas"].ToString();
                        txtPatente.Text = reader["Vehiculo_Patente"].ToString();
                        txtCondicion.Text = reader["Vehiculo_Condicion"].ToString();
                        txtKM.Text = reader["Vehiculo_Kilometraje"].ToString();
                        txtPrecio.Text = reader["Vehiculo_Precio"].ToString();
                        dtpIngreso.Value = Convert.ToDateTime(reader["Vehiculo_Ingreso"]);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un vehículo con ese código");
                    }
                }

            }

        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Solo permitir un punto/coma decimal
            if ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as TextBox).Text.Contains('.') || (sender as TextBox).Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void txtKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}