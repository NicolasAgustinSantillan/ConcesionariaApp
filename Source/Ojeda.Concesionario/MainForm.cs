using System.Drawing;

namespace Ojeda.Concesionario
{
    public partial class MainForm : Form
    {
        const int RESIZE = 10;
        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(RESIZE);          // <-- borde libre para el resize
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            tableLayoutPanel_ALL.Dock = DockStyle.Fill;  // ocupa todo menos el padding
            tableLayoutPanel_ALL.Margin = Padding.Empty;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
