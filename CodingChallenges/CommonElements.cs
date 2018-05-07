using System.Collections.Generic;

namespace CodingChallenges
{
    /* Given two ascending sorted arrays A, B the solution
     * should find the elements common in the two arrays
     * and return an array of the common elements.
     * 
     * Find the solution in O(max(n,m)) where n is the lenght of A
     * and m is the lenght of B.
     */
    public class CommonElements
    {
        public int[] solution(int[] A, int[] B)
        {
            List<int> result = new List<int>();

            int a = 0;
            int b = 0;

            while (a < A.Length && b < B.Length)
            {
                if (A[a] == B[b])
                {
                    result.Add(A[a]);
                    a++;
                    b++;
                }
                else if (A[a] < B[b])
                    a++;
                else
                    b++;
            }

            return result.ToArray();
        }
    }
}
