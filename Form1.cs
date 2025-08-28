using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcesionariaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
        }

        private void CargarVehiculos(string filtro = "")
        {
            string query = "SELECT * FROM Vehiculos";

            if (filtro == "Nuevos")
                query += " WHERE Vehiculo_Kilometraje = 0";
            else if (filtro == "Usados")
                query += " WHERE Vehiculo_Kilometraje > 0";

            dgvVehiculos.DataSource = DBHelper.GetTable(query);
        }

        private void rbNuevos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNuevos.Checked) CargarVehiculos("Nuevos");
        }

        private void rbUsados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsados.Checked) CargarVehiculos("Usados");
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked) CargarVehiculos();
        }

        private void btnABM_Click(object sender, EventArgs e)
        {
            FormABM frm = new FormABM();
            frm.ShowDialog();
            CargarVehiculos();
        }
    }
}
