using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.BasicAlgorithms
{
    class Permutation
    {
         // Permutate, [1,2,3] [1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]
        public static string s;

        public static List<string> Perm(string S)
        {
            if (S == "") return null;

            List<string> A=new List<string>();
            if (S.Length == 1) {
                string a=S;
                A.Add(a);
                return A;
            }

            //for S.lenght>1
            for (int i = 0; i < S.Length; i++)
            {
                    // a, b ,c 
                //     0, 1 ,2
                char x = S[i];
                string subS = S.Substring(0, i) + S.Substring(i + 1, S.Length-(i+1)); //abc.subString(0,1) 
                List<string> B=Perm(subS);
                for (int j = 0; j < B.Count;j++)
                {
                    B[j] = x.ToString() + B[j].ToString();
                }

                A.AddRange(B);
            }

            return A;

        }
    }
}
