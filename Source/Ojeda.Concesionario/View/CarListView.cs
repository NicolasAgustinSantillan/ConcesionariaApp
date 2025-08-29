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

            this.GenerateColumns();

            this.carRepository = new CarRepository(Program.ConnectionString);
            var cars = carRepository.Get();

            this.LoadData(cars);
        }

        private void GenerateColumns()
        {
            this.Cars_ListView.Columns.Add("Id", 50);
            this.Cars_ListView.Columns.Add("Marca", 100);
            this.Cars_ListView.Columns.Add("Modelo", 100);
            this.Cars_ListView.Columns.Add("Precio", 80);

            this.Cars_ListView.Items.Clear();
        }

        private void LoadData(List<Car> listaCars)
        {
            foreach (var v in listaCars)
            {
                var item = new ListViewItem(v.Id.ToString());
                item.SubItems.Add(v.Brand);
                item.SubItems.Add(v.Model);
                item.SubItems.Add(v.Price.ToString("C"));
                this.Cars_ListView.Items.Add(item);
            }
        }

    }
}
