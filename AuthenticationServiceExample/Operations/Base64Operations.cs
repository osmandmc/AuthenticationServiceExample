using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationServiceExample.Operations
{
    public abstract class Base64Operations
    { 
        public static string Encode(string text)
        {
            var textBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textBytes);
        }
        public static string Decode(string encodedString)
        {
            var encodedStringBytes = System.Convert.FromBase64String(encodedString);
            return System.Text.Encoding.UTF8.GetString(encodedStringBytes);
        }
    }
}
