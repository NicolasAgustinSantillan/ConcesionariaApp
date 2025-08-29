using Ojeda.Concesionario.DB.DataAccess;
using Ojeda.Concesionario.DB.Entities;
using Ojeda.Concesionario.Resources;

namespace Ojeda.Concesionario.View
{
    public partial class CarListView : Form
    {
        private CarRepository carRepository;

        private Dictionary<string, string> columns = new Dictionary<string, string>()
        {
            { "Id",     "Id"        },
            { "Brand",  "Marca"     },
            { "Model",  "Modelo"    },
            { "Price",  "Precio"    }
        };

        public CarListView()
        {
            InitializeComponent();

            this.carRepository = new CarRepository(Program.ConnectionString);

            DataGridViewStyler.ApplyDefaultStyle(this.dgv_cars, this.columns);

            this.LoadData();
        }

        private void LoadData()
        {
            var cars = carRepository.Get();

            foreach (var v in cars)
            {
                this.dgv_cars.Rows.Add(v.Id.ToString(), v.Brand, v.Model, v.Price.ToString("C"));
            }
        }

    }
}
