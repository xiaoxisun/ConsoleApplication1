using System;

/*Define,
 * Given an input number n, check whether any integer m from 2 to n − 1 evenly divides n 
 * (the division leaves no remainder). If n is divisible by any m then n is composite,
 * otherwise it is prime.
 * Since a prime is only divisible by 1 and itself
There are many ways to test a number if it is prime number. including: 
 *   
 * 1. divide n by every integer from 2 to square root n. If n is divisible by any 
 * m then n is composite, otherwise it is prime.
 * 
 * 
 * 2.  Fermat little theorm,  
 *     for any 1<a<p, 
 *     a^(p-1)=1(mod p) if yes, it is prime number else no. 
 *     
 *     random pick more a to test. 
 *     
 *     Tips: how to caculate n power of an interger.
 *     O(n):   for 1 to n multiple n times. 
 *     O(logn): divide and conquer: 
 *            x^n/2 * x^n/2, if n is even
 *            x^(n-1)/2 * x(n-1)/2, if n is odd.
 * */
namespace BasicAlgorithms
{
    public class IsPrime 
    {
        public static void IsPrimeSqrt(long A)
        {
            double nFloorSqrt;
            bool bIsPrime;

            bIsPrime = true;

            if (A <= 0) Console.WriteLine("Prime test is only for positive interger. Please enter a valid number.");
            long mod = 0;
            if (A > 0)
            {
                //nFloorSqrt = Convert.ToInt32(Math.Floor(Math.Sqrt(A)));
                nFloorSqrt = Math.Sqrt(A);

                Console.WriteLine("nFloorSqrt=" + nFloorSqrt);

                for (long i = 1; i <= nFloorSqrt; i++)
                {
                    if (i == 1) continue;

                    mod = A % i;
                    //Console.WriteLine("mod=" + mod +"  i="+i);
                    if (mod == 0) { bIsPrime = false; break; }
                }

                if (bIsPrime == true)
                    Console.WriteLine("Yes, it is a prime number.");
                else
                    Console.WriteLine("No, it is not a prime number.");
            }
        }


        public static void IsPrimeFermat(ulong A)
        {
            if (A <= 1) 
            {
                Console.WriteLine("No, it is not a prime number.");
                return;
            }

            if (A % 2 ==0) 
            {
                Console.WriteLine("No, it is not a prime number.");
                return;
            }

            //Random rnd = new Random();
            int a=2;
            
            Console.WriteLine("a="+a);

            ulong nRemaider = ModExp(2, A - 1, A);
            //ulong nRemaider = ModExp(4, 13, 497);

            Console.WriteLine("nRemaider=" + nRemaider);

            if (nRemaider == 1)
                Console.WriteLine("Yes, it is a prime number.");
            else
                Console.WriteLine("No, it is not a prime number.");
        }


        public static ulong ModExp(ulong nBase, ulong nPower, ulong divider)
        {
            if (nPower==0) return 1;
            
            ulong ulReducedPower;
            if (nPower % 2 == 1) ulReducedPower = (nPower - 1) / nBase;
            else ulReducedPower = nPower / nBase;

            Console.WriteLine("nReducedPower=" + ulReducedPower);
            ulong z = ModExp(nBase, ulReducedPower, divider);

            Console.WriteLine("z=" + z);

            ulong c = (z * z) % divider;
            if (nPower % 2 == 1)//Odd
            {
                c=(c * nBase) % divider;
            }

            return c;
        }


    }
}
