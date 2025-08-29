using Ojeda.Concesionario.DB.DataAccess;
using System.ComponentModel;
using System.Reflection;

namespace Ojeda.Concesionario.Resources
{
    public abstract class DataGridCustom : Form
    {
        public const string ActionColum = "Acciones";
        protected void CellPainting(DataGridView dgv, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns[ActionColum].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                int buttonWidth = (e.CellBounds.Width - 10) / 2;
                int buttonHeight = e.CellBounds.Height - 6;

                Rectangle editButton = new Rectangle(e.CellBounds.Left + 5, e.CellBounds.Top + 3, buttonWidth, buttonHeight);
                Rectangle deleteButton = new Rectangle(e.CellBounds.Left + buttonWidth + 10, e.CellBounds.Top + 3, buttonWidth, buttonHeight);

                ButtonRenderer.DrawButton(e.Graphics, editButton, "🖋️", dgv.Font, false, System.Windows.Forms.VisualStyles.PushButtonState.Normal);
                ButtonRenderer.DrawButton(e.Graphics, deleteButton, "♻️", dgv.Font, false, System.Windows.Forms.VisualStyles.PushButtonState.Normal);

                e.Handled = true;
            }
        }

        public static void ApplyDefaultStyle(DataGridView dgv, Dictionary<string, string> columns)
        {
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.White;
            dgv.Font = new Font("Roboto", 10);
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.MultiSelect = false;

            // Encabezados centrados y con color
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 246, 252);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(242, 246, 252);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor = MaterialSkin.MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Selección estilo Material  rgb()
            dgv.DefaultCellStyle.SelectionBackColor = MaterialSkin.MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(242, 246, 252);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Roboto", 10);

            foreach (var column in columns)
            {
                var col = dgv.Columns.Add(column.Key, column.Value);
                if (column.Key == column.Value)
                {
                    dgv.Columns[col].Visible = false;
                }
            }
        }

        public static Dictionary<string, string> GetColums(Type type)
        {
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var columns = props.ToDictionary(
                p => p.Name,
                p =>
                {
                    var attr = p.GetCustomAttribute<DisplayNameAttribute>();
                    return attr?.DisplayName ?? p.Name;
                }
            );

            return columns;
        }

        public static void AddActionColumn(DataGridView dgv)
        {
            // Evito agregarla dos veces
            if (dgv.Columns.Contains("Acciones"))
                return;

            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
            btnCol.HeaderText = "Acciones";
            btnCol.Name = "Acciones";
            btnCol.Text = "Editar/Eliminar";   // texto por defecto
            btnCol.UseColumnTextForButtonValue = false; // usamos texto dinámico
            dgv.Columns.Add(btnCol);
        }

        public static ActionEnum GetAction(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv.Columns[ActionColum].Index)
            {
                var cellBounds = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                int buttonWidth = (cellBounds.Width - 10) / 2;

                // Coordenadas del clic
                var clickX = dgv.PointToClient(Cursor.Position).X - cellBounds.Left;


                if(clickX < buttonWidth + 5)
                {
                    return ActionEnum.Edit;
                }
                else
                {
                    return ActionEnum.Delete;
                }
            }

            return ActionEnum.None;
        }
    }

    public enum ActionEnum
    {
        Edit = 1,
        Delete = 2,
        None = 3
    }

}
