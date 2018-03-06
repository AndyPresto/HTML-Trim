using System;
using System.Text.RegularExpressions;

namespace HTML_Trim
{
    public class HTML_Trim
    {

        private static Regex reg = new Regex(@"(?<=[^])\t{2,}|(?<=[>])\s{2,}(?=[<])|(?<=[>])\s{2,11}(?=[<])|(?=[\n])\s{2,}");

        public string TrimHTMLString(string Html)
        {
            if (!String.IsNullOrEmpty(Html))
            {
                Html = reg.Replace(Html, string.Empty);
            }
            else
            {
                return "";
            }

            return Html;
        }

    }
}
