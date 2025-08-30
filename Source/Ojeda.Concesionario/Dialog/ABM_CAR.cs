using Ojeda.Concesionario.DB.DataAccess;
using Ojeda.Concesionario.DB.Entities;
using Ojeda.Concesionario.Resources;
using System.Runtime.InteropServices;

namespace Ojeda.Concesionario.Dialog
{
    public partial class ABM_CAR : Form
    {
        public bool isEdit;
        private CarRepository carRepository;

        public Car Car { get; set; }

        public ABM_CAR(DB.DataAccess.CarRepository carRepository, Car car = null)
        {
            InitializeComponent();

            this.Padding = new Padding(2);

            this.isEdit = car != null;
            this.carRepository = carRepository;

            if (this.isEdit)
            {
                this.lbl_title.Text = $"Edicion de auto: {car.Brand} - {car.Model}";
                this.Car = car;
                this.btn_accept.Text = "Editar";
            }
            else
            {
                this.lbl_title.Text = "Crear auto";
                this.Car = new Car();
                this.btn_accept.Text = "Crear";
            }

            LoadControls();
        }

        private void LoadControls()
        {
            List<int> years = new List<int>();
            for (int i = DateTime.Now.Year; i >= 1920; i--)
            {
                years.Add(i);
            }
            cmb_year.DataSource = years;

            if (!isEdit)
            {
                return;
            }

            this.txt_code.Text = this.Car.Code;
            this.txt_brand.Text = this.Car.Brand;
            this.txt_model.Text = this.Car.Model;
            this.txt_kilometers.Text = this.Car.Kilometers.ToString();
            this.txt_price.Text = this.Car.Price.ToString();
            this.txt_type.Text = this.Car.Type;
            this.cmb_year.SelectedItem = this.Car.Year;
            this.txt_description.Text = this.Car.Description;
            this.txt_patent.Text = this.Car.Patent;

            if (Car.Photo != null)
            {
                using (var ms = new MemoryStream(Car.Photo))
                {
                    pic_photo.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pic_photo.Image = null; // o una imagen por defecto
            }

        }

        private void btn_accept_click(object sender, EventArgs e)
        {
            bool result = this.ValidateFields();

            if (result)
                return;

            this.fillDto();

            if (this.isEdit)
                this.carRepository.Update(this.Car);
            else
                this.carRepository.Add(this.Car);

            this.Close();
        }

        private bool ValidateFields()
        {
            bool error = false;

            if (TextBoxHelper.ValidateTextBox_Void(this.txt_brand))
                error = true;

            if (TextBoxHelper.ValidateTextBox_Void(this.txt_model))
                error = true;

            if (TextBoxHelper.ValidateTextBox_Void(this.txt_type))
                error = true;


            if (!isEdit && !error)
                this.txt_code.Text = this.txt_brand.Text.Substring(0, 1).ToUpper() +
                    this.txt_model.Text.Substring(0, 1).ToUpper() +
                    Convert.ToString(new Random().Next(1000, 10000));

            if (this.txt_kilometers.Text == "")
                this.txt_kilometers.Text = "0";
            else
            {
                if (TextBoxHelper.ValidateTextBox_Int(this.txt_kilometers))
                    error = true;
            }


            if (this.txt_price.Text == "")
                this.txt_price.Text = "0";
            else
            {
                if (TextBoxHelper.ValidateTextBox_Decimal(this.txt_price))
                    error = true;
            }

            return error;
        }

        private void fillDto()
        {
            this.Car.Code = this.txt_code.Text;
            this.Car.Brand = this.txt_brand.Text;
            this.Car.Model = this.txt_model.Text;
            this.Car.Kilometers = Convert.ToInt32(this.txt_kilometers.Text);
            this.Car.Price = Convert.ToDecimal(this.txt_price.Text);
            this.Car.Type = this.txt_type.Text;
            this.Car.Year = Convert.ToInt32(this.cmb_year.SelectedValue);
            this.Car.Description = this.txt_description.Text;
            this.Car.Patent = this.txt_patent.Text;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_loadphoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var imageBytes = File.ReadAllBytes(ofd.FileName);
                    this.Car.Photo = imageBytes;

                    pic_photo.Image = Image.FromFile(ofd.FileName);
                }
            }

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
