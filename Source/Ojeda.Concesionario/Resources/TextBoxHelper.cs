using MaterialSkin.Controls;

namespace Ojeda.Concesionario.Resources
{
    public static class TextBoxHelper
    {
        public static bool ValidateTextBox_Void(MaterialTextBox2 textBox)
        {
            if (textBox.Text.Trim() == "")
            {
                textBox.SetErrorState(true);
                return true;
            }
            textBox.SetErrorState(false);
            return false;
        }

        public static bool ValidateTextBox_Int(MaterialTextBox2 textBox)
        {
            try
            {
                _ = Convert.ToInt32(textBox.Text);
            }
            catch
            {
                textBox.SetErrorState(true);
                return true;
            }
            textBox.SetErrorState(false);
            return false;
        }

        public static bool ValidateTextBox_Decimal(MaterialTextBox2 textBox)
        {
            try
            {
                _ = Convert.ToDecimal(textBox.Text);
            }
            catch
            {
                textBox.SetErrorState(true);
                return true;
            }
            textBox.SetErrorState(false);
            return false;
        }
    }
}
