using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1.BasicAlgorithms
{

    public class Combinations
    {

        //// print all subsets of the characters in s
        //public static void comb1(String s) { comb1("", s); }

        //// print all subsets of the remaining elements, with given prefix 
        //private static void comb1(String prefix, String s) {
        //    if (s.Length > 0) {
        //        Console.WriteLine(prefix + s.charAt(0));
        //        comb1(prefix + s.charAt(0), s.substring(1));
        //        comb1(prefix,               s.substring(1));
        //    }
        //}

        public static int C(int n, int k)
        {
            if (k == 0) return 1;
            if (n == 0) return 0;

            int c = C(n - 1, k - 1) + C(n-1,k);

            return c;
        }

        // alternate implementation
        public static void comb2(String s) {comb2("", s); }
        private static void comb2(String prefix, String s) {
            Console.WriteLine(prefix);
            for (int i = 0; i < s.Length; i++)
                comb2(prefix + s[i], s.Substring(i + 1));
        }

        public static List<List<int>> comb(int n)
        {
            List<int> a = new List<int>();
            List<List<int>> A = new List<List<int>>();
            if (n == 1) 
            {
                a.Add(n);
                A.Add(a);
                return A;
            }

            //plus n it self
            a.Add(n);
            A.Add(a);

            //plus a combin n with all element return from comb(n-1);
           List<List<int>> B=comb(n-1);
           List<List<int>> C = comb(n - 1);
           foreach (List<int> temp in C)
           {
               temp.Add(n);
           }

           A.AddRange(B);
           A.AddRange(C);
           
           return A;
        }


//        证明组合的递推公式
//C(n,m)=C(n-1,m-1)+C(n-1,m)
 
//1.将C(n,m)理解为在n个物体中取m个物体的方案总数；
//2.现在将n个物体分成一号堆n-1个物体和二号堆1个物体；
//3.n个物体的二号堆只有1个物体，分为取和不取两种情况；
//4.若取，则从一号堆的n-1个物体中取出m-1个物体，为C(n-1,m-1)；
//5.若不取，则从一号堆的n-1个物体中取出m个物体，为C(n-1,m)；
//6.因此，C(n,m)的方案总数为C(n-1,m-1)和C(n-1,m)的总和；
//7.证毕。
        public static List<List<int>> comb(int n, int k)
        {
            List<List<int>> A = new List<List<int>>();
            if (n <= 0 || k <=0 || k > n) { return A; }

            List<int> a = new List<int>();
            if (k == n)
            {
                for (int i = 1; i <= k; i++)
                    a.Add(i);
                A.Add(a);
            }
            else if (k < n)
            {
                //plus a combine n with all element return from comb(n-1);
                List<List<int>> B = comb(n - 1, k - 1);
                foreach (List<int> b in B)
                {
                    b.Add(n);
                }
                if ((k - 1) == 0)
                {
                    B.Add(new List<int>(1) {n});
                  
                }
                A.AddRange(B);

                List<List<int>> C = comb(n - 1, k);
                A.AddRange(C);
            }
           

            return A;
        }

        
        // read in N from command line, and print all subsets among N elements
        public static void main(String[] args) {
       //int N = Int32.Parse(args[0]);
       //String alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
       //String elements = alphabet.Substring(0, N);

       ////// using first implementation
       ////comb1(elements);
       ////System.out.println();

       ////// using second implementation
       //comb2(elements);
       //Console.WriteLine();
        }

    }


}
