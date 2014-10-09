using System;
using BasicDataStructure;
using System.Collections;
/// <summary>
/// array-based string stack 
/// </summary>
///

namespace MyNamespace
{
    public class stringQuestions
    {
        static void Test(string[] args)
        {
            ConsoleKeyInfo cki;
               
            /*
            char x = "test"[0];
            Console.WriteLine("x="+x);
            */
            string test = "abcde";
            Console.WriteLine(revserseString(test));
            string test2 = "eecdba";
            Console.WriteLine(revserseString(test2));

            //
            cki = Console.ReadKey();
        }


        //1. Implement an algorithm to determine if a string has all unique characters. What if you can not use additional data structures?
        public static bool isUniqueChar(string sInput)
        {
            Hashtable hTable = new Hashtable(sInput.Length);

            foreach (char c in sInput) 
            {
                if (hTable[c] == null) { hTable.Add(c, 1); }
                else { return false; }
            }

            return true;
        }


        //2. Write code to reverse a C-Style String. (C-String means that “abcd” is represented as five characters, including the null character.)
        public static string revserseString(string sInput)
        {
            char[] cArray = sInput.ToCharArray();
            string sOutput="";

            for (int i = cArray.Length-1; i >-1;i-- )
            {
                sOutput += cArray[i];
            }

            return sOutput;
        }

        //public static string reverseString2(string sInput)
        //{
        //    string sOutput = string.Empty;
        //    foreach (char ch in sInput)
        //    {
 
        //    }
        //}

        //3. Design an algorithm and write code to remove the duplicate characters in a string without using any additional buffer. NOTE: One or two additional variables are fine. An extra copy of the array is not.
        public void removeDupulicateCharWithoutBuffer(char[] str) 
        {
            int map = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((map & (1 << (str[i] - 'a'))) > 0) // duplicate detected
                    str[i] = '0';
                else // add unique char as a bit '1' to the map
                    map |= 1 << (str[i] - 'a');
            }
        }

        
        public string removeDupulicateCharWithBuffer(string sInput)
        {
            string sOutput = "";
            return sOutput;
        }


        public string sTest1;

        public string sTest
        {
            set { sTest1 = value + " 1"; }
            get { return sTest1; }
        }

       


    }
  
}
