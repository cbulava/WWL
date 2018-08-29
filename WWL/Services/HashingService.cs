using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WWL.Services
{
    public class HashingService
    {
        public byte[] GenerateSalt()
        {
            byte[] salt = new byte[32];
            System.Security.Cryptography.RNGCryptoServiceProvider.Create().GetBytes(salt);
            return salt;
        }

        public byte[] GenerateHashWithSalt(byte[] salt, string password)
        {
            //https://stackoverflow.com/questions/212510/what-is-the-easiest-way-to-encrypt-a-password-when-i-save-it-to-the-registry
            // Convert the plain string pwd into bytes
            byte[] passwordBytes = System.Text.UnicodeEncoding.Unicode.GetBytes(password);
            // Append salt to pwd before hashing
            byte[] combinedBytes = new byte[passwordBytes.Length + salt.Length];
            System.Buffer.BlockCopy(passwordBytes, 0, combinedBytes, 0, passwordBytes.Length);
            System.Buffer.BlockCopy(salt, 0, combinedBytes, passwordBytes.Length, salt.Length);

            // Create hash for the pwd+salt
            System.Security.Cryptography.HashAlgorithm hashAlgo = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = hashAlgo.ComputeHash(combinedBytes);

            return hash;
        }

    }
}
