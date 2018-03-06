using System;
using HTML_Trim;

namespace HTML_Trim_Console
{
    class HTML_Trim_Console
    {
        static void Main(string[] args)
        {
            var html = "";

            Console.WriteLine("Enter your HTML string");

            if (!String.IsNullOrEmpty(html = Console.ReadLine()))
            {
                var HTML_Trim = new HTML_Trim.HTML_Trim();

                Console.WriteLine("Minifying");
                HTML_Trim.TrimHTMLString(html);
                Console.WriteLine("HTML minified");
            };

            Console.WriteLine("Your minified HTML string is: " + Environment.NewLine + html);

            Console.ReadLine();
        }
    }
}

