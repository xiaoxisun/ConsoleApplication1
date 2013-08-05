using System;


namespace MyNamespace
{
    public class MyStack
    {
        //Implementation of array-based stack is very simple. It uses top variable to point to the topmost stack's element in the array.
        int top;
        string[] storage;

        public MyStack(int iCapacity)
        {
            //
            // TODO: Add constructor logic here
            //
            if (iCapacity <= 0)
            {
                Console.WriteLine("empty stack capacity!");
            }
            else
            {
                top = -1;
                storage = new string[iCapacity];
            }

        }

        public bool push(string sValue)
        {
            if (top == storage.Length)
            {
                Console.WriteLine("The stack is full.");
                return false;
            }
            else
            {
                top++;
                storage[top] = sValue;
                Console.WriteLine();
                return true;
            }
        }

        public bool pop()
        {
            if (top == -1)
            {
                Console.WriteLine("The stack is empty.");
                return false;
            }
            else
            {
                storage[top] = "";
                top--;
                return true;
            }
        }

        public string peak()
        {
            if (top != -1)
                return storage[top];
            else
                return "";
        }

        public bool isEmpty()
        {
            if (top == -1) return true;
            else return false;
        }

    }
}