using Ojeda.Concesionario.DB.DataAccess;
using Ojeda.Concesionario.DB.Entities;
using Ojeda.Concesionario.Resources;

namespace Ojeda.Concesionario.View
{
    public partial class CarListView : DataGridCustom
    {
        private CarRepository carRepository;

        private Dictionary<string, string> columns;

        private List<Car> carsList;

        public CarListView()
        {
            InitializeComponent();

            this.carRepository = new CarRepository(Program.ConnectionString);

            this.columns = GetColums(typeof(Car));

            ApplyDefaultStyle(this.dgv_cars, this.columns);

            AddActionColumn(this.dgv_cars);

            this.LoadData();
        }

        private void LoadData()
        {
            try
            {
                this.dgv_cars.Rows.Clear();
            }
            catch {}

            Task.Run(() =>
            {
                this.carsList = carRepository.Get();
            }).Wait();

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

        private void dgv_cars_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            base.CellPainting(dgv_cars, e);
        }

        private void dgv_cars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var action = GetAction(dgv_cars, e);

            if (action == ActionEnum.None)
            {
                return;
            }

            var carSelected = CurrentCarSelected();

            if (action == ActionEnum.Edit)
            {
                MessageBox.Show($"Editar fila {e.RowIndex}");
            }
            else if (action == ActionEnum.Delete)
            {
                if (MessageDialog.ConfirmDelete(carSelected.Brand))
                {
                    carRepository.Delete(carSelected.Id);
                }
            }

            this.LoadData();
        }
    }
}
