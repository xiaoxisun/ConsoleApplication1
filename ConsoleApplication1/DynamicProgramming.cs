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
            string A = "trails";
            string B = "zeil";
            int nDistance=DynamicProgramming.LevenshteinDistance(A,B);
            Console.Write("nDistance="+nDistance);
        }

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
        
    }

}
