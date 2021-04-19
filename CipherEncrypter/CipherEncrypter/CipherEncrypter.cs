using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherEncrypter
{
    static class CipherEncrypter
    {
        public static string Encrypt(string inputString)
        {
            string encryptedOutputString = string.Empty;
            byte[] charArray = Encoding.ASCII.GetBytes(inputString);

            foreach (byte asciiValue in charArray)
            {
                int asciiIncremented = asciiValue + 1;
                encryptedOutputString += asciiIncremented + "-";
            }
            encryptedOutputString = encryptedOutputString.Substring(0, encryptedOutputString.Length - 1);
            return encryptedOutputString;
        }

        public static string Decrypt(string encryptedString)
        {
            string decryptedOutputString = string.Empty;
            string[] encryptedArray = encryptedString.Split('-');


            foreach (string asciiValueIncremented in encryptedArray)
            {
                int asciiValue = int.Parse(asciiValueIncremented) - 1;
                char c = Convert.ToChar(asciiValue);

                decryptedOutputString += c;
            }

            return decryptedOutputString;
        }
    }
}
