using System;
using System.Collections.Generic;
using System.Text;


namespace DecoderEncoder
{
    public class CaesarShiftCipher : ICipher
    {
        public CaesarShiftCipher()
        {
            CipherName = "Caesar Shift";
        }
        public string CipherName { get; set; }
        /// <summary>
        /// Encodes string with a Caesar Shift using the shift value
        /// </summary>
        /// <param name="message"></param>
        /// <param name="shiftValue"></param>
        /// <returns></returns>
        public string Encode(string message, int shiftValue)
        {
            return Ciphers.Caesar.CaesarShiftCipherFunctions.ShiftPlaintext(message, shiftValue);
        }

        /// <summary>
        /// Decodes string with a Caesar Shift using the shift value
        /// </summary>
        /// <param name="message"></param>
        /// <param name="shiftValue"></param>
        /// <returns></returns>
        public string Decode(string message, int shiftValue)
        {
            return Ciphers.Caesar.CaesarShiftCipherFunctions.ShiftCiphertext(message, shiftValue);
        }
    }
}
