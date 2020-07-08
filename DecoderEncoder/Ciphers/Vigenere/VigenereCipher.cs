using System;
using DecoderEncoder.Ciphers.VigenereCipher;
using DecoderEncoder.Factory;
using System.Collections.Generic;
using System.Text;


namespace DecoderEncoder.Ciphers.Vigenere
{
    public class VigenereCipher : ICipher
    {
        public VigenereCipher()
        {
            CipherName = "Vigenere Cipher";
        }

        public string CipherName { get; set; }

        public string Encode(string message, string keyword)
        {
            string keywordString = VigenereCipherFunctions.CreateKeywordString(StringFormatter.FormatString(message), StringFormatter.FormatString(keyword));
            string ciphertext = VigenereCipherFunctions.CreateCiphertext(StringFormatter.FormatString(message), StringFormatter.FormatString(keywordString));

            return ciphertext;
        }

        public string Decode(string ciphertext, string keyword)
        {
            string keywordString = VigenereCipherFunctions.CreateKeywordString(StringFormatter.FormatString(ciphertext), StringFormatter.FormatString(keyword));
            string plaintext = VigenereCipherFunctions.CreatePlaintext(StringFormatter.FormatString(ciphertext), StringFormatter.FormatString(keywordString));

            return plaintext;
        }
    }
}
