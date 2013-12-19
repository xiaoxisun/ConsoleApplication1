using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//
/*
 * Questions: Given a array A[n], find the maximum differencet between two elements max(A[j]-A[i]), such that j>i
 * 
 * 1. O(n^2)
 * 
 *
 * 2. O(n), Space O(n)
 */
namespace ConsoleApplication1.BasicAlgorithms
{
    class LargestDiffBetweenTwoElementInArray
    {
        public int[] Input;

        public LargestDiffBetweenTwoElementInArray()
        {
            Input= new int[]{10,3,6,8,9,4,3};
        }

        public int GetLargestDiff()
        {
            int result=-1;
            if (Input.Length < 2) return result;
            
            int max = 0;
            //build array Rmax;
            int[] Rmax = new int[Input.Length];
            for (int i = Input.Length-1; i >=0 ; i--)
            {
                   
                if (Input[i] > max)
                    max = Input[i];
                Rmax[i] = max;

                if (max - Input[i] > result) result = max - Input[i];
            }

            return result;
        }

    }
}
