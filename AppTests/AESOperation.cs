using System.Security.Cryptography;
using System.Text;

namespace AppModule
{
    static class AESOperation
    {
        public static string AsymmetricKey = "a1s2d33f4g5h6j7k8l9.0q1w2e3r4t5y";

        public static string Encrypt(string str)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(AsymmetricKey);
                aes.IV = new byte[16];

                ICryptoTransform encryptor = aes.CreateEncryptor();

                using MemoryStream memoryStream = new();

                using (StreamWriter streamWriter = new StreamWriter(new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)))
                {
                    streamWriter.Write(str);
                }

                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }

        public static string Decrypt(string str)
        {
            byte[] buffer = Convert.FromBase64String(str);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(AsymmetricKey);
                aes.IV = new byte[16];
                ICryptoTransform decryptor = aes.CreateDecryptor();

                string result;
                using MemoryStream memoryStream = new(buffer);
                using (StreamReader streamReader = new StreamReader(new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)))
                {
                    result = streamReader.ReadToEnd();
                }

                return result;
            }
        }
    }
}
