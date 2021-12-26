using System;
using System.Security.Cryptography;
using Org.BouncyCastle.Security;


namespace Task4
{
    public class EncryptionHandler
    {
        byte[] key;
        public EncryptionHandler()
        {
            key = new Byte[32];
        }
        public byte[] GetHmac(int move)
        {
            Random random = new SecureRandom();
            for (int i = 0; i < key.Length; i++)
            {
                key[i] = Convert.ToByte(random.Next(0, 127));
            }
            HMACSHA256 hmac = new HMACSHA256(key);
            return hmac.ComputeHash(BitConverter.GetBytes(move));
        }
        public void PrintKey()
        {
            foreach (var item in key)
                Console.Write(item.ToString("X2"));
        }
    }
}
