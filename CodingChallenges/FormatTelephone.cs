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
            string str = Regex.Replace(S, @"[^0-9]", "");
            string result = "";
                        
            int a = 3;
            int b = 2;

            int bSegments = (str.Length * b) % a;
            int aSegments = (str.Length - b * bSegments) / a;

            for (int i = 0; i < aSegments; i++)
            {
                result += str.Substring(0, a) + "-";
                str = str.Remove(0, a);
            }
            for (int i = 0; i < bSegments; i++)
            {
                result += str.Substring(0, b) + "-";
                str = str.Remove(0, b);
            }
            result = result.Substring(0, result.Length - 1);
            return result;
        }
    }
}
