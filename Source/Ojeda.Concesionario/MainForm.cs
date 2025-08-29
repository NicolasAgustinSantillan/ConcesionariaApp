using Ojeda.Concesionario.Resources;
using Ojeda.Concesionario.View;
using System.Windows.Forms;

namespace Ojeda.Concesionario
{
    public partial class MainForm : Form
    {
        const int RESIZE = 10;
        public MainForm()
        {
            InitializeComponent();

            this.Padding = new Padding(RESIZE);          // <-- borde libre para el resize
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            tableLayoutPanel_ALL.Dock = DockStyle.Fill;  // ocupa todo menos el padding
            tableLayoutPanel_ALL.Margin = Padding.Empty;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Desing.RoundPanel(panel_main, 15);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_main_Resize(object sender, EventArgs e)
        {
            Desing.RoundPanel(panel_main, 15);
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_CarsList_Click(object sender, EventArgs e)
        {
            var view = new CarListView();
            LoadFormInMainPanel(view);
        }

        private void LoadFormInMainPanel (Form form)
        {
            panel_main.Controls.Clear();
            var task = Task.Run(() =>
            {
                var view = form;
                view.TopLevel = false;
                view.FormBorderStyle = FormBorderStyle.None;
                view.Dock = DockStyle.Fill;
                return view;
            });

            task.Wait();
            var view = task.Result;

            panel_main.Controls.Add(view);
            view.Show();
        }

    }
}
