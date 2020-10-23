using System;

namespace ImplementExtensionForString
{
    public class Program
    {
        static void Main(string[] args)
        {
            var text = "Some text";

            var result = StringExtensions.ApplyWhiteSpace(text, 10);
            text = text.ApplyWhiteSpace(3);
        }
    }
}
