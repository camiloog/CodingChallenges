using System.Collections.Generic;

namespace CodingChallenges
{
    /* Given a string S find the first
     * non repeating character found in
     * the string. 
     * 
     * Return null if there aren't.
     * 
     * Expected O(N) solution.
     */
    public class NonRepeatingCharacter
    {
        public char? solution(string S)
        {
            Dictionary<char, int> table = new Dictionary<char, int>();

            foreach (char c in S)
            {
                if (table.ContainsKey(c))
                    table[c] += 1;
                else
                    table[c] = 1;
            }

            foreach (char c in table.Keys)
            {
                if (table[c] == 1)
                    return c;
            }

            return null;
        }
    }
}
