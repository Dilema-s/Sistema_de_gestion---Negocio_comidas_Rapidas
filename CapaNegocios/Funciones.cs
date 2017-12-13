using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocios
{
    public class Funciones
    {
        public static void mError(Form formActual, string mensaje)
        {
            MessageBox.Show(formActual, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void mOk(Form formActual, string mensaje)
        {
            MessageBox.Show(formActual, mensaje, "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool mConsulta(Form formActual, string mensaje)
        {
            if (MessageBox.Show(formActual, mensaje, "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        // Boolean flag used to determine when a character other than a number is entered.
        public static bool nonNumberEntered = false;



        public static void esDecimal_keyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        if (e.KeyCode != Keys.OemPeriod)
                        {
                            // A non-numerical keystroke was pressed.
                            // Set the flag to true and evaluate in KeyPress event.
                            nonNumberEntered = true;
                        }
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }


        public static void esEntero_keyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {


            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {                   
                            // A non-numerical keystroke was pressed.
                            // Set the flag to true and evaluate in KeyPress event.
                            nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

        }

        public static bool isNull(string t)
        {     
            return string.IsNullOrWhiteSpace(t); //para saber si es null o tiene espacios en blanco
        }
        
        public static bool length(string t)
        {
            if (t.Length < 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //public static void esNum_keyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    // Check for the flag being set in the KeyDown event.
        //    if (nonNumberEntered == true) // si es true en una tecla no-numerica
        //    {
        //        // Stop the character from being entered into the control since it is non-numerical.
        //        e.Handled = true;

        //    }
        //}










































        //// Boolean flag used to determine when a character other than a number is entered.
        //private static bool nonNumberEntered = false;

        //// Handle the KeyDown event to determine the type of character entered into the control.
        //private static void txtPrecioCosto_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    // Initialize the flag to false.
        //    nonNumberEntered = false;

        //    // Determine whether the keystroke is a number from the top of the keyboard.
        //    if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
        //    {
        //        // Determine whether the keystroke is a number from the keypad.
        //        if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
        //        {
        //            // Determine whether the keystroke is a backspace.
        //            if (e.KeyCode != Keys.Back)
        //            {
        //                // A non-numerical keystroke was pressed.
        //                // Set the flag to true and evaluate in KeyPress event.
        //                nonNumberEntered = true;
        //            }
        //        }
        //    }
        //    //If shift key was pressed, it's not a number.
        //    if (Control.ModifierKeys == Keys.Shift)
        //    {
        //        nonNumberEntered = true;
        //    }
        //}

        //// This event occurs after the KeyDown event and can be used to prevent
        //// characters from entering the control.
        //private static void txtPrecioCosto_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        //{
        //    // Check for the flag being set in the KeyDown event.
        //    if (nonNumberEntered == true)
        //    {
        //        // Stop the character from being entered into the control since it is non-numerical.
        //        e.Handled = true;
        //    }
        //}




    }
}
