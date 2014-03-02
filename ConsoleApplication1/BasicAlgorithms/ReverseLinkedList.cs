using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms
{
    public class ReverseLinkedList
    {
        LinkedList<int> A = new LinkedList<int>();

        public ReverseLinkedList() {
            A.AddLast(1);
            A.AddLast(2);
            A.AddLast(3);
            A.AddLast(4);
        }
   
        public void reverse() {
            if (A.First == null) { return; }

            LinkedList<int> B = new LinkedList<int>();

            while (A.Count > 0)
            {
                /*
                LinkedListNode<int> b = A.Last;
                B.AddLast(b);
                A.RemoveLast();
                */
                //The above three lines throws an InvalidOperationException with a message of "The LinkedList node already belongs to a LinkedList."
                //It doesn't let you arbitrarily add nodes from one list to another. They must be removed from the list and then added to the other list. 
 
                LinkedListNode<int> b = A.Last;
                A.RemoveLast();
                B.AddLast(b);
            }


            foreach (int i in B)
            {
                Console.WriteLine(i);
            }
            return;
        }

    }
}
