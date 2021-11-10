using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.Logic
{
    static class Utils
    {
        public static byte[] DecodeBase64(this string value)
        {
            var valueBytes = System.Convert.FromBase64String(value);
            return valueBytes;
        }
    }
}
