using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DecoderEncoder.Factory
{
    public static class AlphabetCreator
    {
        public static string Create()
        {
            string alphabet = "";

            for (char c = 'A'; c <= 'Z'; c++)
            {
                alphabet = alphabet + c;
            }

            return alphabet;
        }

        public static string CreateWithShift(int shiftValue)
        {
            char[] alphabetArray = new char[26];
            string alphabetNew = "";

            shiftValue = 26 - shiftValue;         

            for (char c = 'A'; c <= 'Z'; c++)
            {
                if(shiftValue >= 26)
                {
                    shiftValue -= 26;
                }
                alphabetArray[shiftValue] = c;
                shiftValue++;
            }

            foreach(char c in alphabetArray)
            {
                alphabetNew = alphabetNew + c.ToString();
            }

            return alphabetNew;
        }
    }
}
