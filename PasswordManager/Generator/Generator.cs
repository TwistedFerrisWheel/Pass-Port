using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class Generator
    {

        protected static char[] totalChars = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '?', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };


        public static string generate(int length, bool specialCheck)
        {
            var rnd = new byte[length];
            using (var rng = new RNGCryptoServiceProvider())
                rng.GetBytes(rnd);
            var allowable = new char[] {};


            if (!specialCheck) {
                int numAllowable = 50;
                allowable = new char[numAllowable];
                for (int chr = 0; chr < numAllowable; chr++)
                {
                    allowable[chr] = totalChars[chr];
                }
            } else
            {
                allowable = totalChars;
            }

            var len = allowable.Length;
            var characters = new char[length];
            for (var i = 0; i < length; i++)
                characters[i] = allowable[rnd[i] % len];

            return new string(characters);
        }

    }
}
