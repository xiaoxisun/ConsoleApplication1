using System;
using BasicDataStructure;
using System.Collections;
/// <summary>
/// array-based string stack 
/// </summary>
///

namespace MyNamespace
{
    public class NumbersChecker
    {
         public static void Test()
        {
            ConsoleKeyInfo cki;
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

        
            //int[] iArray = {1,2,3,4,5,6,7,8,9,20,11,13,15,17,19,21,23,24,25,26,27,29,33,39,41,47,49,50,77,79,90,91,93,97,98,100};
            int[] iArray = { 982451653 };
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.WriteLine(iArray[i] + ":" + isPrimeNumber(iArray[i]));
            }

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine(ts);
            //  
            cki = Console.ReadKey();
        }

          public static bool isPrimeNumber(int aNumber)
          {
              if (aNumber == 1) return false;
              if (aNumber == 2) return true;

              if (aNumber >= 2)
              {
                  for (int i = 2; i < Math.Sqrt(aNumber); i++)
                  {
                      if (aNumber % i == 0) return false;
                  }
                  return true;
              }
              else {
                  return false;
              }
          }

    }
  
}
