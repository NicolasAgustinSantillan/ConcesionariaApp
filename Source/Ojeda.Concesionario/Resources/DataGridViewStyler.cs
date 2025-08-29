using Ojeda.Concesionario.DB.Entities;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace Ojeda.Concesionario.Resources
{
    public static class DataGridViewStyler
    {
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
        
        public static Dictionary<string, string> GetColumnd(Type type)
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
    }
}
