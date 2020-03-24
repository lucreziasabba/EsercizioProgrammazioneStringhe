using System;
using System.Globalization;

namespace EserciziStringhe
{
    public class Metodi
    {
        public static bool AreEquals(string s1, string s2)
        {
            if (s1 == s2)
                return true;
            else
                return false;
        }
        public static bool ContainsDoubleChar(string s)
        {
            if (s.Contains("A") || s.Contains("E") || s.Contains("I") || s.Contains("O") || s.Contains("U"))
                return true;
            else
                return false;
        }
        public static string Convert(string s3)
        {
            string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s3);
            return (titleCase);
        }
    }
}
