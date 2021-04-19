using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chatroom.Utilities
{
    public class Utilities
    {
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            byte[] bytes = new MD5CryptoServiceProvider().ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }

            return hash.ToString();
        }
    }
}
