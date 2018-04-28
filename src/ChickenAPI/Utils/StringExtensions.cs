using System;
using System.Security.Cryptography;
using System.Text;

namespace ChickenAPI.Utils
{
    public static class StringExtensions
    {
        public static string ToSha512(this string str)
        {
            using (var sha = new SHA512Managed())
            {
                byte[] tmp = sha.ComputeHash(Encoding.UTF8.GetBytes(str));
                return Encoding.UTF8.GetString(tmp);
            }
        }
    }
}