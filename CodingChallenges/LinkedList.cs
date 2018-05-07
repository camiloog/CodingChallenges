namespace CodingChallenges
{
    /* Given a no empty array of items A implementing a 
     * linked list, write a function to return the number of nodes
     * of the list if the firs item represents the first node, its
     * value represent the index of the next node on the array and
     * a value of -1 represent the last node of the list.
     */
    public class LinkedList
    {
        public int solution(int[] A)
        {
            int nodeIndex = 0;
            int nodesCount = 1;

            while (A[nodeIndex] != -1)
            {
                nodesCount++;
                nodeIndex = A[nodeIndex];
            }

            return nodesCount;
        }
    }
}
