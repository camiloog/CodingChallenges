namespace CodingChallenges
{
    /* Given the arrays of integers A and B define a 
     * function that returns true if B is a rotation 
     * of array A. 
     * 
     * Assume there are no duplicates ant they have the 
     * same length.
     * 
     * Expected solution in O(N)
     */
    public class IsArrayRotationOfArray
    {
        public bool solution(int[] A, int[] B)
        {
            if (A.Length != B.Length)
                return false;

            int b = -1;

            for (int i = 0; i < B.Length; i++)
            {
                if (A[0] == B[i])
                    b = i;
            }

            if (b == -1)
                return false;
            
            for (int a = 0; a < A.Length; a++)
            {
                if (A[a] != B[b])
                    return false;
                b = (b + 1) % B.Length;
            }

            return true;
        }
    }
}
