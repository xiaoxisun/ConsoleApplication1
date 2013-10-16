using System;

/*  The median of a list of numbers is its 50th percentile: half the numbers are bigger than it,
and half are smaller.
 *   A simple way is to sort the list and get the median of the group, 
 * if there are even number of elements, then the median is a pair. 
 * 
 * O(nlogn)
 * 
 * Another Linear O(n) method is using divide-and-conquer algorithm. 
 * We have reason to be hopeful, because sorting is doing far more work than we really needwe just want the middle
 * element and don't care about the relative ordering of the rest of them.
 * 
 * When looking for a recursive solution, it is paradoxically often easier to work with a more
general version of the problemfor the simple reason that this gives a more powerful step to
recurse upon.
 * 
 * 
 * 
For any number v, imagine splitting list S
into three categories: elements smaller than v, those equal to v (there might be duplicates),
and those greater than v. Call these SL, Sv, and SR respectively. For instance, if the array
S : 2 36 5 21 8 13 11 20 5 4 1
is split on v = 5, the three subarrays generated are
SL : 2 4 1 Sv : 5 5 SR : 36 21 8 13 11 20
The search can instantly be narrowed down to one of these sublists. If we want, say, the
eighth-smallest element of S, we know it must be the third-smallest element of SR since
jSLj + jSvj = 5. That is, selection(S; 8) = selection(SR; 3). More generally, by checking k
against the sizes of the subarrays, we can quickly determine which of them holds the desired
element:
 * 
 * */

namespace BasicAlgorithms
{
    public class GetMedian
    {
        int n;
        double p;
        bool bDebug=false;

        private int nMedian;
        public int[] A;

        public GetMedian(){
            //A = new int[] {1, 3, 4, 2, 7, 7, 8, 9, 10, 14, 24, 17, 6, 0, 1,7};
            //A = new int[] { 1, 3, 4, 0, 1, 7 };
            Random rnd = new Random();
            int size = 10000000;
            A = new int[size];
            int i=0;
            while (i < A.Length)
            {
                A[i] = rnd.Next(0, size);
                //A[i] = i;
                i++;
            }
        }

        public int _Median(){
            return nMedian;
        }

        public int Selection(int[] A, int k)
        {
            if (bDebug) Console.WriteLine("============");
            if (bDebug) Console.WriteLine("Selection Start");
            //int kthIndex = k - 1;
            if (A.Length == 1) return A[0];
            int kthValue=0;
            /*
             * 1. Get a random number RandomIndex
             * 2. Walk through the list 
             *    a. L
             *    b. v
             *    c. R
             * 3. Decide which list to go futher down. Checking k against the sizes of the subarrays. 
             *     Selection(S,k) = 1. Selection(SL,k)            if k<= |SL|
             *                      2. v                          if |SL| < k <= |SL|+|Sv|
             *                      3. Selection(SR,k-|SL|-|Sv|)  if k> |SL|+|Sv|
             * 4. Recursively call SelectKth() on target Sublist until there is only one element and return this element. 
             * 
            */

            if (bDebug)
            {
                int j = 0;
                while (j < A.Length)
                {
                    Console.WriteLine(A[j].ToString());
                    j++;
                }
            }

            //1. Get the random number RandomIndex.
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0,A.Length);
            int RandomValue =A[RandomIndex];

            if (bDebug)
            {
                Console.WriteLine("test point 1 A.Length:" + A.Length);
                Console.WriteLine("test point 1 k:" + k);
                Console.WriteLine("test point 1 RandomIndex:" + RandomIndex);
                Console.WriteLine("test point 1 RandomValue:" + RandomValue);
            }
            //2. Walk through the list, split the input array into 3 sets in place.
            //using two pointers and a swap
           
            int nFront=0, nEnd=A.Length-1;

            while (nFront < nEnd)
            {
                while (A[nFront] <= RandomValue && nFront < nEnd)
                {
                    nFront++;
                }

                while (A[nEnd] > RandomValue && nFront < nEnd)
                {
                    nEnd--;
                }

                int temp = A[nFront];
                A[nFront] = A[nEnd];
                A[nEnd] = temp;
            }

            if (bDebug)
            {
                int j = 0;
                while (j < A.Length)
                {
                    Console.WriteLine(A[j].ToString());
                    j++;
                }
            }
            //.
            nFront = 0;
            nEnd = A.Length - 1;
            while (nFront < nEnd)
            {
                while (A[nFront] != RandomValue && nFront < nEnd)
                {
                    nFront++;
                }

                while (A[nEnd] >= RandomValue && nFront < nEnd)
                {
                    nEnd--;
                }

                int temp = A[nFront];
                A[nFront] = A[nEnd];
                A[nEnd] = temp;
            }

            //
            int nEndSL = 0, nStartSR = A.Length;
            nFront = 0;
            nEnd = A.Length - 1;
            while (nFront < A.Length - 1)
            {
                if (A[nFront] >= RandomValue) { break; }
                nEndSL = nFront;
                nFront++;
            }

            while (nEnd > nFront)
            {
                if (bDebug) Console.WriteLine("nEnd:" + nEnd);
                if (A[nEnd] <= RandomValue) {  break; }
                nStartSR = nEnd;
                nEnd--;
            }

            //if (nStartSR == A.Length - 1) { }
            if (bDebug)
            {
                Console.WriteLine("test point 2");
                int j = 0;
                while (j < A.Length)
                {
                    Console.WriteLine(A[j].ToString());
                    j++;
                }
                Console.WriteLine("nEndSL: " + nEndSL);
                Console.WriteLine("nStartSR: " + nStartSR);
            }
            //System.Console.ReadKey();

            //3. Decide which list to go further down. checking k against the subarray length. 
            // Selection(S,k) = 1. Selection(SL,k)            if k<= |SL|
            //*                 2. v                          if |SL| < k <= |SL|+|Sv|
            //*                 3. Selection(SR,k-|SL|-|Sv|)  if k> |SL|+|Sv|
            if (k <= (nEndSL + 1))
            {
                int[] SL = new int[nEndSL + 1];
                for (int i = 0; i < nEndSL + 1; i++) SL[i] = A[i];
                kthValue = Selection(SL, k);
            }
            else if (k > (nEndSL + 1) && k <= (nStartSR))
            {
                kthValue = A[nEndSL + 1];
            }
            else
            {
                int[] SR = new int[A.Length - nStartSR];
                for (int i = 0; i < A.Length - nStartSR; i++) SR[i] = A[nStartSR + i];
                kthValue = Selection(SR, k - nStartSR);
            }

            //System.Console.ReadKey();
            return kthValue;
           
        }

         
    }

}
