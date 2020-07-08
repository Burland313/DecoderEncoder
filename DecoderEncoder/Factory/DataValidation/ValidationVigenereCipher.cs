using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace DecoderEncoder.Factory.DataValidation
{
    public static class ValidationVigenereCipher
    {
        public static bool ValidatePlaintext(string message)
        {
            bool isValid = !message.Any(char.IsDigit);
            
            if(isValid)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a message of just letters");
                return false;
            }
        }

        public static bool ValidateKeyword(string keyword)
        {
            bool isValid = !keyword.Any(char.IsDigit);

            if(isValid)
            { 
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a message of just letters");
                return false;
            }
        }
    }
}
