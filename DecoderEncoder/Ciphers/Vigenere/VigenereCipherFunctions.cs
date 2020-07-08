using System;
using System.Collections.Generic;
using System.Text;

namespace DecoderEncoder.Ciphers.VigenereCipher
{
    public static class VigenereCipherFunctions
    {
        /// <summary>
        /// Creates keyword string to use for getting ciphertext or plaintext
        /// </summary>
        /// <param name="message"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static string CreateKeywordString(string message, string keyword)
        {
            string keywordString = "";

            if (Factory.DataValidation.ValidationVigenereCipher.ValidateKeyword(keyword))
            {
                int messageLength = message.Length;
                int keywordLength = keyword.Length;
                int iterations = messageLength / keywordLength;

                char[] keywordActual = keyword.ToCharArray();

                for (int i = 0; i <= iterations; i++)
                {
                    for (int j = 0; j < keywordLength; j++)
                    {
                        if (keywordString.Length < messageLength)
                        {
                            keywordString += keywordActual[j];
                        }
                    }
                }
            }
            return keywordString;
        }

        /// <summary>
        /// Creates ciphertext from message using keyword string
        /// </summary>
        /// <param name="message"></param>
        /// <param name="keywordString"></param>
        /// <returns></returns>
        public static string CreateCiphertext(string message, string keywordString)
        {
            string outputString = "";

            if (Factory.DataValidation.ValidationVigenereCipher.ValidatePlaintext(message))
            {
                int currentIndex = 0;

                char[] keywordArray = keywordString.ToUpper().ToCharArray();
                char[] alphabet = Factory.AlphabetCreator.Create().ToCharArray();

                foreach (var c in keywordArray)
                {
                    int keywordIndex = Array.IndexOf(alphabet, c);
                    int messageIndex = Array.IndexOf(alphabet, message[currentIndex]);
                    int cipherIndex;

                    if (keywordIndex + messageIndex > 25)
                    {
                        cipherIndex = keywordIndex + messageIndex - 26;
                    }
                    else
                    {
                        cipherIndex = keywordIndex + messageIndex;
                    }

                    currentIndex++;
                    outputString += alphabet[cipherIndex];
                }
            }
            return outputString;
        }

        /// <summary>
        /// Creates plain text from encoded message using a keyword string
        /// </summary>
        /// <param name="ciphertext"></param>
        /// <param name="keywordString"></param>
        /// <returns></returns>
        public static string CreatePlaintext(string ciphertext, string keywordString)
        {
            string outputString = "";
            int currentIndex = 0;

            char[] keywordArray = keywordString.ToCharArray();
            char[] alphabet = Factory.AlphabetCreator.Create().ToCharArray();

            foreach (var c in keywordArray)
            {

                int keywordIndex = Array.IndexOf(alphabet, c);
                int ciphertextIndex = Array.IndexOf(alphabet, ciphertext[currentIndex]);
                int messageIndex;

                if (keywordIndex - ciphertextIndex < 0)
                {
                    messageIndex = ciphertextIndex - keywordIndex;
                }
                else
                {
                    messageIndex = 26 - (keywordIndex - ciphertextIndex);
                }

                currentIndex++;
                outputString += alphabet[messageIndex];
            }

            return outputString;
        }
    }
}
