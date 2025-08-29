using Ojeda.Concesionario.DB.DataAccess;
using Ojeda.Concesionario.DB.Entities;

namespace Ojeda.Concesionario.View
{
    public partial class CarListView : Form
    {
        private CarRepository carRepository;

        public CarListView()
        {
            InitializeComponent();

            this.GenerateStyle();
            //this.GenerateColumns();

            this.carRepository = new CarRepository(Program.ConnectionString);
            var cars = carRepository.Get();

            this.LoadData(cars);
        }

        private void GenerateStyle()
        {

            this.dgv_cars.Dock = DockStyle.Fill;
            this.dgv_cars.ReadOnly = true;
            this.dgv_cars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cars.AllowUserToAddRows = false;
            this.dgv_cars.AllowUserToResizeColumns = false;
            this.dgv_cars.AllowUserToResizeRows = false;
            this.dgv_cars.RowHeadersVisible = false;
            this.dgv_cars.EnableHeadersVisualStyles = false;
            this.dgv_cars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cars.BackgroundColor = Color.White;
            this.dgv_cars.BorderStyle = BorderStyle.None;
            this.dgv_cars.GridColor = Color.White;
            this.dgv_cars.Font = new Font("Roboto", 10);


            // Encabezados centrados y con color
            this.dgv_cars.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 246, 252);
            this.dgv_cars.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(242, 246, 252);

            this.dgv_cars.ColumnHeadersDefaultCellStyle.ForeColor = MaterialSkin.MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            this.dgv_cars.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10, FontStyle.Bold);
            this.dgv_cars.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Selección estilo Material  rgb()
            this.dgv_cars.DefaultCellStyle.SelectionBackColor = MaterialSkin.MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            this.dgv_cars.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgv_cars.DefaultCellStyle.BackColor = Color.FromArgb(242, 246, 252);
            this.dgv_cars.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_cars.DefaultCellStyle.Font = new Font("Roboto", 10);

            // Agregar columnas
            this.dgv_cars.Columns.Add("Id", "Id");
            this.dgv_cars.Columns.Add("Brand", "Marca");
            this.dgv_cars.Columns.Add("Model", "Modelo");
            this.dgv_cars.Columns.Add("Price", "Precio");

        }

        private void LoadData(List<Car> listaCars)
        {
            foreach (var v in listaCars)
            {
                this.dgv_cars.Rows.Add(v.Id.ToString(), v.Brand, v.Model, v.Price.ToString("C"));
            }
        }

    }
}
