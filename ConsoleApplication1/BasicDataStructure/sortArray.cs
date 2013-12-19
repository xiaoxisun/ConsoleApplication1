using System;
using BasicDataStructure;
using System.Collections;
/// <summary>
/// array-based string stack 
/// </summary>
///

namespace MyNamespace
{
    public class sortArray
    {
        bool bDebug = false;

         public static void Test()
        {
            ConsoleKeyInfo cki;
            
             //Bubble sort test
             //==============================
            //int[] a = { 10, 1, 3, 3, 4, 2, 6, 8, 5 };
            sortArray aSortArray = new sortArray();
            //int[] output = aSortArray.BubbleSort(a);

            ////Console.WriteLine(output.GetHashCode());
            //foreach (int i in output)
            //    Console.Write(i + " ");
            //==============================

             //Merge Sort test
             //==============================
             //ArrayList b = new ArrayList(){ 10, 1,7,3,4,2,6,8,5};
             ArrayList b = new ArrayList() {"c","b","a","k","l" };
             ArrayList c = aSortArray.Merge_Sort(b);
             
             //Console.WriteLine(output.GetHashCode());
             //Console.WriteLine(c.Count + " is count ");
             foreach (string i in c)
                 Console.Write(i + " ");
             //==============================
            cki = Console.ReadKey();
        }


        //
         public int[] BubbleSort(int[] inputArray)
         {
             bool bSwapped = true;
             if (inputArray.Length > 0)
             {
                 while (bSwapped == true)
                 {
                     bSwapped = false;
                     for (int i = 0; i < inputArray.Length - 1; i++)
                     {
                         if (inputArray[i] > inputArray[i + 1])
                         {
                             int temp = inputArray[i];
                             inputArray[i] = inputArray[i + 1];
                             inputArray[i + 1] = temp;
                             bSwapped = true;
                         }
                     }
                 }
             }

             return inputArray;
         } //Big O n!-->n^2 

        public ArrayList Merge_Sort(ArrayList A)
        {
	        // split the array into left and right, 
	        int n=A.Count;
	
	        if (n>1){
	            ArrayList B =new ArrayList();
	            ArrayList C= new ArrayList();
 
	            B=Merge_Sort(A.GetRange(0,n/2));
	            C=Merge_Sort(A.GetRange(n/2,n-n/2));
                
                ArrayList M=Merge(B, C);

	            return M;
            }
            else return A;
        }

         public ArrayList Merge(ArrayList left, ArrayList right)
         {
             int leftPos = 0;
             int rightPos = 0;

             if (bDebug == true)
             {
                 foreach (int i in left)
                     Console.Write(i + " ");

                 foreach (int i in right)
                     Console.Write(i + " ");
             }

             ArrayList Result = new ArrayList(left.Count + right.Count) { };
             int newPos = 0;
             
             while (newPos < left.Count + right.Count)
             {
                 if (leftPos >= left.Count)
                 {
                     Result.Add(right[rightPos]);
                     rightPos++;
                 }
                 else if (rightPos >= right.Count)
                 {
                     Result.Add(left[leftPos]);
                     leftPos++;
                 }
                 else if (left[leftPos].GetHashCode() <= right[rightPos].GetHashCode() )
                 {
                     Result.Add(left[leftPos]);
                     leftPos++;
                 }
                 else
                 {
                     Result.Add(right[rightPos]);
                     rightPos++;
                 }
               
                 newPos++;
             }
             return Result;
         }



    }
  
}
