using System.Text.RegularExpressions;

namespace CodingChallenges
{
    /* Given a string with a phone number including chars
     * different from numbers, make a function to format the 
     * phone number so is expressed in groups of 3 numbers
     * in the end they can be grouped in one or two groups of 
     * 2 numbers.
     */
    public class FormatTelephone
    {
        public string solution(string S)
        {
            string s = Regex.Replace(S, @"[^0-9]", "");
            string result = "";

            int a = 3;
            int b = 2;

            int sb = (s.Length * b) % a;
            int sa = (s.Length - b * sb) / a;

            for (int i = 0; i < sa; i++)
            {
                result += s.Substring(0, a) + "-";
                s = s.Remove(0, a);
            }
            for (int i = 0; i < sb; i++)
            {
                result += s.Substring(0, b) + "-";
                s = s.Remove(0, b);
            }
            result = result.Substring(0, result.Length - 1);
            return result;
        }
    }
}
