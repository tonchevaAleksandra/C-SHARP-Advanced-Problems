using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementExtensionForString
{
    public static class StringExtensions
    {
        public static string ApplyWhiteSpace(this string input, int count=1)//int count=1 - it's default value for the method if we don't give another value to operate with
        {
            var whiteSpace = new string(' ', count);

            return $"{whiteSpace}{input}{whiteSpace}";

        }
    }
}
