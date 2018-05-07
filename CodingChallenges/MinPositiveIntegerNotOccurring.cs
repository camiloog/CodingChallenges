namespace CodingChallenges
{
    /* Given the array A find the minimum positive
     * integer not occurring on the array.
     * 
     * Expected solution on O(N) and maximum O(N) of 
     * space.
     */
    public class MinPositiveIntegerNotOccurring
    {
        public int solution(int[] A)
        {
            bool[] PositiveInts = new bool[A.Length];

            foreach (var a in A)
            {
                if (a < 0)
                    continue;
                if (a > A.Length)
                    continue;
                PositiveInts[a - 1] = true;
            }

            for (int i = 0; i < PositiveInts.Length; i++)
            {
                if (!PositiveInts[i])
                    return i + 1;
            }

            return A.Length + 1;
        }
    }
}
