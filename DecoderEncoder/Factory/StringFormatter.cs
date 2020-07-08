using System;
using System.Collections.Generic;
using System.Text;

namespace DecoderEncoder.Factory
{
    public static class StringFormatter
    {
        public static string FormatString(string input)
        {
            string inputFixed;

            inputFixed = input.Replace(" ", String.Empty).ToUpper();

            return inputFixed;
        }
    }
}
