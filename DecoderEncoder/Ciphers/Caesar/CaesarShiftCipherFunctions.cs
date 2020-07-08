using System;
using System.Collections.Generic;
using System.Text;
using DecoderEncoder.Factory;

namespace DecoderEncoder.Ciphers.Caesar
{
    public static class CaesarShiftCipherFunctions
    {
        public static string ShiftPlaintext(string message, int shiftValue)
        {
            string outputString = "";

            if (Factory.DataValidation.ValidationCaesarShift.ValidateShiftValue(shiftValue))
            {
                char[] alphabet = AlphabetCreator.Create().ToCharArray();
                char[] alphabetShift = AlphabetCreator.CreateWithShift(shiftValue).ToCharArray();
                char[] inputArray = StringFormatter.FormatString(message).ToCharArray();

                foreach (var c in inputArray)
                {
                    int i = Array.IndexOf(alphabet, c);
                    outputString += alphabetShift[i];
                }
            }

            return outputString;
        }

        public static string ShiftCiphertext(string message, int shiftValue)
        {
            string outputString = "";

            if (Factory.DataValidation.ValidationCaesarShift.ValidateShiftValue(shiftValue))
            {
                char[] alphabet = AlphabetCreator.Create().ToCharArray();
                char[] alphabetShift = AlphabetCreator.CreateWithShift(shiftValue).ToCharArray();
                char[] inputArray = message.ToUpper().ToCharArray();

                foreach (var c in inputArray)
                {
                    int i = Array.IndexOf(alphabetShift, c);
                    outputString += alphabet[i];
                }
            }

            return outputString;
        }
    }


}
