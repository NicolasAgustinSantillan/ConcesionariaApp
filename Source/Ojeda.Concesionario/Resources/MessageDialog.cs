namespace Ojeda.Concesionario.Resources
{
    public static class MessageDialog
    {
        public static bool ConfirmDelete(string itemName)
        {
            var result = MessageBox.Show(
                $"¿Está seguro que desea eliminar {itemName}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            return result == DialogResult.Yes;
        }
    }
}
