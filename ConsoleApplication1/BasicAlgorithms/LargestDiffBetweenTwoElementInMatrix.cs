using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//
/*
 * Questions: Given a matrix A[n,n], find the maximum differencet between two elements max(A[c,d]-A[a,b]), such that c>a,d>b
 * 
 * dinagnol tranverse, 
 * keep record the maximum 
 * 
 * 1. O(n^2)
 * 
 *
 * 2. O(n), Space O(n)
 * 
 * 
 */
namespace ConsoleApplication1.BasicAlgorithms
{
    class LargestDiffBetweenTwoElementInMatrix
    {
        public int[,] Input= new int[6,6]{
            {10,3,6,8,9,4},
            {10,3,6,8,9,4},
            {10,3,6,8,9,4},
            {10,3,6,16,9,4},
            {10,3,6,8,10,4},
            {10,3,6,8,9,12}
            
            };
        //{10,3,6,8},
        //{10,3,6,8},
        //{10,3,6,8},
        //{10,3,6,8,}
        public LargestDiffBetweenTwoElementInMatrix()
        {

        }

        public int GetLargestDiff()
        {
            int result=-1;
            // 
            // if (Input < 2 && ) return result;

            int maxDiff = 0;
            //build array Rmax;
            int ColMin=100000;
            int RowMin=100000;
            int OverallMin=100000;

            //Diagonal tranverse 
            //Total row number is 2*(n-1), so maximum index is 2*(n-1)-1
            // sume of index i,j is equal for each Diagonal tranverse  row: sum=i+j=row id

            int rowIndex=2*(Input.GetLength(0)-1)-1;

            int i=0;
            int j=0;

            for (int sum = 0; sum <= rowIndex; sum++)//sum increase 
            {
                Console.Write("sum[" + sum + ", ");

                //In each Diagonal tranverse row, sum=i+j, 
                // i start from sum and i-- for following element,  
                // j start from 0 and j++ for folloing element

                //if i > n , then i start with n, i--
                // j start with sum-i; j++
                if (sum < Input.GetLength(0) - 1)
                { i = sum; j=0; }
                else
                {
                    i = Input.GetLength(0) - 2; j = sum - i;
                }

                // tranvser each element in a row  
                while (j < Input.GetLength(0) - 1 && (i+j)==sum && (i>=0 && i < Input.GetLength(0) - 1))
                {
                    //print index for each element
                    Console.Write("A[" + i + ", " + j + "]  ");
                    
                    //keep track of min for either row or column, 
                    if (Input[i, j] < ColMin) ColMin = Input[i, j];
                    if (Input[i, j] < RowMin) RowMin = Input[i, j];

                    //again keep track of min among all elements A[x,y] such that x<i,y<j;
                    OverallMin = Math.Min(RowMin, ColMin);

                    //keep updateing the maximum difference, since min is been tracked. 
                    if ((Input[i + 1, j + 1] - OverallMin) > result)
                        result = (Input[i + 1, j + 1] - OverallMin);
                    
                    //iterate index for each row. 
                    i--;
                    j++;
                }
                Console.Write("\n");
            }
            return result;
        }

    }
}
