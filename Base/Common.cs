using System;
using System.Security.Cryptography;
using System.Text;

namespace WooCommerce.NET.Base
{
    public static class Common
    {
        static Common()
        {
            DebugInfo = new StringBuilder();
        }

        public static StringBuilder DebugInfo { get; set; }

        public static string GetUnixTime(bool micro)
        {
            long unixtime = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).Ticks;

            if (!micro)
            {
                DebugInfo.AppendLine(unixtime.ToString().Substring(0, 10));
                return unixtime.ToString().Substring(0, 10);
            }

            DebugInfo.AppendLine("0." + unixtime.ToString().Substring(10, 6) + "00 " + unixtime.ToString().Substring(0, 10));

            return "0." + unixtime.ToString().Substring(10, 6) + "00 " + unixtime.ToString().Substring(0, 10);
        }

        public static string GetSha1(string key, string message)
        {
            var encoding = new ASCIIEncoding();

            byte[] keyBytes = encoding.GetBytes(key);
            byte[] messageBytes = encoding.GetBytes(message);

            string sha1Result;

            using (HMACSHA1 sha1 = new HMACSHA1(keyBytes))
            {
                var hashed = sha1.ComputeHash(messageBytes);
                sha1Result = Convert.ToBase64String(hashed);
            }

            return sha1Result;
        }

        public static string GetSha256(string key, string message)
        {
            return HmacSha256.Hmac(Encoding.UTF8.GetBytes(message), Encoding.UTF8.GetBytes(key));
            //MacAlgorithmProvider sha256 = MacAlgorithmProvider.OpenAlgorithm("HMAC_SHA256");
            //IBuffer contentBuffer = CryptographicBuffer.ConvertStringToBinary(message, BinaryStringEncoding.Utf8);

            //IBuffer keyBuffer = CryptographicBuffer.ConvertStringToBinary(key, BinaryStringEncoding.Utf8);
            //var signatureKey = sha256.CreateKey(keyBuffer);

            //IBuffer digest = CryptographicEngine.Sign(signatureKey, contentBuffer);

            //return CryptographicBuffer.EncodeToBase64String(digest);
        }

        public static string GetMd5(string content)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(content));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }
    }
}
