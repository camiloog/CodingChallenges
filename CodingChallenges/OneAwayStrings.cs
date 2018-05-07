using System;

namespace CodingChallenges
{
    /* Given two strings A and B return true if they 
     * are one operation away from each other.
     * 
     * the allowed operations are: change a character, 
     * remove a character and add a character.
     * 
     * Expected solution in O(N).
     */
    public class OneAwayStrings
    {
        public bool solution(string A, string B)
        {
            if (Math.Abs(A.Length - B.Length) > 1)
                return false;
            else if (A.Length == B.Length)
            {
                if (A == B)
                    return true;
                int diff = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j] != B[j])
                    {
                        diff++;
                        if (diff > 1)
                            return false;
                    }
                }
            }
            else
            {
                string large = A;
                string small = B;
                if (B.Length > A.Length)
                {
                    large = B;
                    small = A;
                }

                int i = 0;
                int diff = 0;
                while (i < small.Length)
                {
                    if (large[i + diff] == small[i])
                        i++;
                    else
                    {
                        diff++;
                        if (diff > 1)
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
