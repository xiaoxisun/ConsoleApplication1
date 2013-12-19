using System;

/*

 * */
namespace BasicDataStructure
{
    public class DynamicProgramming 
    {
        public DynamicProgramming()
        {
 
        }

        public static void test()
        {
            //string A = "trails";
            //string B = "zeil";
            //int nDistance=DynamicProgramming.LevenshteinDistance(A,B);
            //Console.Write("nDistance="+nDistance);

            int[] A = {5,2,8,6,3,6,9,7};
            int nLength = DynamicProgramming.LongestIncreaseSubsequece(A);
            Console.Write("Length=" + nLength);
        }

        /**
         * Edit Distance
         * 
         * 
         * 
        */
        public static int LevenshteinDistance(string A, string B)
        {
            int nLD = 0;
            int m = A.Length;
            int n = B.Length;


            int[,] G=new int[m+1,n+1];

            G[0,0]=0;

            for (int i = 1; i < m + 1; i++) G[i, 0] = i;
            for (int j = 1; j < n + 1; j++) G[0, j] = j;

            for (int i = 1; i < m + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (A[i - 1] == B[j - 1]) G[i, j] = G[i - 1, j - 1];
                    else
                    {
                        if (G[i - 1, j - 1] <= G[i - 1, j] && G[i - 1, j - 1] <= G[i, j - 1])
                            G[i, j] = G[i - 1, j - 1] + 1;
                        else if (G[i - 1, j] <= G[i - 1, j - 1] && G[i - 1, j] <= G[i, j - 1])
                            G[i, j] = G[i - 1, j] + 1;
                        else if (G[i, j - 1] <= G[i - 1, j - 1] && G[i, j - 1] <= G[i - 1, j])
                            G[i, j] = G[i , j-1] + 1;
                    }
                }
            }

            nLD=G[m,n];


            return nLD;
        }


        /* 
         * Input: A int array contains a1,a2,...aN, 
         * Ouput: The longest increase subsequece. 
         * 
         * 
         * Dynamic programming:
         * 
         * G=(V,E)
         *  
         *  L(j)=1+max{L(i):(i,j) belong to E}
         *  
         *  When j=1, L=1
         *  j=2, L=1+max(L(1):(1,2) belong to E)
         *  
         * 
         *  Now I define LL[j] is the longest length from index 0 to index i. 
         *  
         *  To compute LL[j], we look at all indices i<j and check if LL[i]+1>LL[j] and A[i]<A[j](we want to make it increasing)
         *  if true we can update LL[j].
         *  
         *  To find the global optimum for the array you can take the maximum value from LL[0,..N-1]
         *  
         This is dynamic programming. In order to solve our original problem, we have defined a
collection of subproblems {L(j) : 1 <=j<=n}  g with the following key property that allows them
to be solved in a single pass:         
         *  There is an ordering on the subproblems, and a relation that shows how to solve
a subproblem given the answers to smaller subproblems, that is, subproblems
that appear earlier in the ordering.
         * 
         * 
         */
        public static int LongestIncreaseSubsequece(int[] A)
        {
            int Length = 0;
            int[] LL = new int[A.Length];
            int[] prev = new int[A.Length];
            Console.WriteLine("A.Length=" + A.Length);
            LL[0] = 1;
            prev[0] = -1;

            int bestEnd=0;
            //5 2 8 6 3 6 9 7
            for (int j = 1; j < A.Length ; j++)
            {

                LL[j]=1;
                for (int i = 0; i < j; i++)
                {
                    if ((LL[i] + 1) > LL[j] && A[i] < A[j])
                    {
                        prev[j] = i;
                        Console.Write(" prev[" + j + "]=" + prev[j]);
                        LL[j] = LL[i] + 1;
                    }
                }

                Console.Write(" LL[" + j + "]=" + LL[j]);
            }


            Console.WriteLine("=====");
            for (int j = 0; j < A.Length - 1; j++)
            {
                if (LL[j] > Length)
                {
                    bestEnd=j;
                    Length = LL[j];
                }
               
            }

            for (int j = bestEnd; j > 0; j--)
            {
                Console.Write(" prev[" + j + "]=" + prev[j]);
                Console.Write(" A[" + j + "]=" + A[prev[j]]);
            }
          

            return Length;
        }
        
    }

}
