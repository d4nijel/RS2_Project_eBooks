using PCLCrypto;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace eBooks.Mobile.Util
{
    public class LoginHelper
    {
        #region Kupci
        public static string GenerateSalt()
        {
            var buf = WinRTCrypto.CryptographicBuffer.GenerateRandom(16);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            var algorithm = WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(PCLCrypto.HashAlgorithm.Sha1);
            byte[] inArray = algorithm.HashData(dst);
            return Convert.ToBase64String(inArray);
        }

        #endregion
    }
}
