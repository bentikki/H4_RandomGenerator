using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator
{
    static class CustomRandom
    {
        public static byte[] GenerateRandomByteArray(int byteLength)
        {
            using (var randomGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[byteLength];
                randomGenerator.GetBytes(randomNumber);

                return randomNumber;
            }
        }
    }
}
