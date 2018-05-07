using System.Collections.Generic;

namespace CodingChallenges
{
    public class MostFrequent
    {
        /* Given the unsorted array A of integers
         * find the most frequent element on the array.
         * 
         * Expected solution in O(N).
         */
        public int? solution(int[] A)
        {
            Dictionary<int, int> table = new Dictionary<int, int>();

            if (A.Length == 0)
                return null;

            int mostFrequentItem = A[0];
            int repetitions = 1;

            foreach (var a in A)
            {
                if (table.ContainsKey(a))
                    table[a] += 1;
                else
                    table[a] = 1;

                if (table[a] > repetitions)
                {
                    repetitions = table[a];
                    mostFrequentItem = a;
                }
            }

            return mostFrequentItem;
        }
    }
}
