using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Practice
{

    
//Given an Array, replace each element in the Array with its Next Element(To its RHS) 
//which is Larger than it. If no such element exists, then no need to replace. 
//Ex: 
//i/p: {2,12,8,6,5,1,2,10,3,2} 
//o/p:{12,12,10,10,10,2,10,10,3,2}



//O(n) Version: 

//> Take stack and Initially push the Index 0 on to the stack. 
//> Traverse All Elements of the Array from left to right. 
//>> If the stack is Empty push the element in the stack. 
//>> If the stack is Non-Empty AND Current-Element > Stack-Top-Index-Element, 
//then replace the Stack-Top-Index element in Array with Current-Element and Pop the Stack. 
//Else Push the Index on to the Stack.	

    class PractiseStack
    {
         int[] input;
         int[] output;

        Stack<int> stackA=new Stack<int>();

        public PractiseStack()
        {
            input =new int[]{ 2, 12, 8, 6, 5, 1, 2, 10, 3, 2 };       
            output =new int[]{ 2, 12, 8, 6, 5, 1, 2, 10, 3, 2 };
        }

        public void Process() {

          //  stackA 
          for (int i = 0; i < input.Length; i++)
          {
              if (i == 0) { stackA.Push(i); }
              else {
                  int pre = stackA.Peek();

                  while (input[i] > input[pre] && stackA.Count > 0)
                  {
                      output[pre] = input[i];
                      stackA.Pop();
                      if (stackA.Count>0)
                        pre = stackA.Peek();
                  }

                  stackA.Push(i);
              }
          }

            for (int i = 0; i < input.Length;i++)
                Console.Write(input[i]+" ");
            Console.WriteLine(" ");
            for (int i = 0; i < output.Length; i++)
                Console.Write(output[i] + " ");
            
        }

    }
}
