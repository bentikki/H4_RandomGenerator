using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherEncrypter
{
    static class CipherEncrypter
    {
        private static readonly int _incrementValue = 8; // Value to increment Ascii value with.

        public static string Encrypt(string inputString)
        {
            string encryptedOutputString = string.Empty;
            byte[] charArray = Encoding.ASCII.GetBytes(inputString); // Convert input string to ASCII char array.

            foreach (byte asciiValue in charArray)
            {
                int asciiIncremented = asciiValue + _incrementValue; // Increment ASCII value with int value.
                encryptedOutputString += asciiIncremented + "-"; // Add seperator.
            }
            // Lazy solution to remove last seperator...
            encryptedOutputString = encryptedOutputString.Substring(0, encryptedOutputString.Length - 1);
            
            // Return "encrypted" string.
            return encryptedOutputString;
        }

        public static string Decrypt(string encryptedString)
        {
            string decryptedOutputString = string.Empty;
            string[] encryptedArray = encryptedString.Split('-');


            foreach (string asciiValueIncremented in encryptedArray)
            {
                int asciiValue = int.Parse(asciiValueIncremented) - _incrementValue;
                char c = Convert.ToChar(asciiValue);

                decryptedOutputString += c;
            }

            return decryptedOutputString;
        }
    }
}
