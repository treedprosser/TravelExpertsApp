using System.Windows.Forms;

namespace TravelExpertsApp
{
    /// <summary>
    /// A repository of validation methods
    /// Author: Brianna Gibson 
    /// Date: August 2022
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// checks if text box has input in it
        /// </summary>
        /// <param name="textBox"> text box to check (needs to have meaningful name)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true;
            if(textBox.Text == "")  //incorrect
            {
                MessageBox.Show(textBox.Tag + " must be provided");
                isValid = false;
                textBox.Focus();    // focus on the textbox to assist user 
            }
            return isValid;
        }

        /// <summary>
        /// checks if combobox is selected 
        /// </summary>
        /// <param name="combo">combo box to check</param>
        /// <returns></returns>
        public static bool IsSeleceted(ComboBox comboBox)
        {
            bool isValid = true;
            if(comboBox.SelectedIndex == -1)    // no selection
            {
                MessageBox.Show(comboBox.Tag + " must be selected");
                isValid = false;
                comboBox.Focus();    // focus on the textbox to assist user
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains double that is greater than or equal to zero 
        /// </summary>
        /// <param name="textBox">text box to check (needs to have meaningful name)</param>
        /// <returns></returns>

        public static bool IsNonNegativeInt(TextBox textBox)
        {
            bool isValid = true;
            decimal value;
            if(!decimal.TryParse(textBox.Text, out value)) // if cannot parse as double
            {
                MessageBox.Show(textBox.Tag + " must be a number");
                isValid = false;
                textBox.SelectAll();
                textBox.Focus();
            }
            else if(value < 0) // double, but negative 
            {
                MessageBox.Show(textBox.Tag + " must be positive or zero");
                isValid = false;
                textBox.SelectAll();
                textBox.Focus();
            }

            return isValid;
        }

        /// <summary>
        /// checks if text box contains int that is between min Value and max Value  
        /// </summary>
        /// <param name="textbox"></param>
        /// <param name="minVal"></param>
        /// <param name="maxVal"></param>
        /// <returns></returns>
        public static bool IsIntInRange(TextBox textbox, int minVal, int maxVal)
        {
            bool IsValid = true;
            decimal value;

            if (!decimal.TryParse(textbox.Text, out value)) // if cannot parse as double
            {
                MessageBox.Show(textbox.Tag + " must be a number");
                IsValid = false;
                textbox.SelectAll();
                textbox.Focus();
            }
            else if (value < 0) // double, but negative 
            {
                MessageBox.Show($"{textbox.Tag}" + " must be { minVal} or { maxVal} ");
                IsValid = false;
                textbox.SelectAll();
                textbox.Focus();
            }

            return IsValid;
        }
    }//class
}//namespace
