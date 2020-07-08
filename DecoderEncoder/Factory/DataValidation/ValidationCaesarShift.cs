using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DecoderEncoder.Factory.DataValidation
{
    public static class ValidationCaesarShift
    {
        public static bool ValidateShiftValue(int toValidate)
        {
            if (toValidate > 26)
            {
                MessageBox.Show("Please select a value between 0-26");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
