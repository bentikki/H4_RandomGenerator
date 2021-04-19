using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string inputString = Console.ReadLine();
            string encryptedString = CipherEncrypter.Encrypt(inputString);

            Console.WriteLine();
            Console.Write("Encrypted string: ");
            Console.WriteLine(encryptedString);

            Console.WriteLine();
            Console.Write("Decrypted string: ");
            string decryptedString = CipherEncrypter.Decrypt(encryptedString);
            Console.WriteLine(decryptedString);

            Console.ReadKey();
        }
    }
}
