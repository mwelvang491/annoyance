using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;

namespace NorthwindClass.Security
{
    public class UserAccount
    {
        public static string HashSHA1(string value)
        {
            //defualt encrption instance.
            var sha1 = System.Security.Cryptography.SHA1.Create();
            //string to byte array conversion.
            var inputBytes = System.Text.Encoding.ASCII.GetBytes(value);
            //input array to hash converstion.
            var hash = sha1.ComputeHash(inputBytes);
           
            var sb = new StringBuilder();

            for (var i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();

        }
    }
}