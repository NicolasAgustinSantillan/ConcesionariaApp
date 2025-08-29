using Ojeda.Concesionario.DB.DataAccess;
using Ojeda.Concesionario.DB.Entities;
using Ojeda.Concesionario.Resources;

namespace Ojeda.Concesionario.View
{
    public partial class CarListView : Form
    {
        private CarRepository carRepository;

        private Dictionary<string, string> columns;

        private List<Car> carsList;

        public CarListView()
        {
            InitializeComponent();

            this.carRepository = new CarRepository(Program.ConnectionString);

            this.columns = DataGridViewStyler.GetColumnd(typeof(Car));

            DataGridViewStyler.ApplyDefaultStyle(this.dgv_cars, this.columns);

            this.LoadData();
        }

        private void LoadData()
        {
            this.carsList = carRepository.Get();

            foreach (var v in carsList)
            {
                this.dgv_cars.Rows.Add(
                    v.Id.ToString(),
                    v.Code,
                    v.Brand,
                    v.Model,
                    v.Kilometers,
                    v.Price.ToString("C"),
                    v.Type,
                    v.Year,
                    v.Description,
                    v.Patent,
                    v.Active,
                    v.IncomeDate
                );
            }
        }

        private Car? CurrentCarSelected()
        {
            if (dgv_cars.CurrentRow != null)
            {
                var result = int.TryParse(dgv_cars.CurrentRow.Cells["Id"].Value?.ToString(), out int id);
                if (result)
                {
                    return carsList?.Where(c => c.Id == id).FirstOrDefault();
                }
            }
            return null;
        }
    }
}
