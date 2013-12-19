using System;
using BasicDataStructure;
/// <summary>
/// array-based string stack 
/// </summary>
///

/*
 * 1. Initialy top =-1
 * 2. push operation increases top by one and writes pushed element to storage[top];
 * 3. pop operation checks that top is not equal to -1 and decreases top variable by -1
 * 4. peek operation checks that top is not equal to -1 and returns storage [top]
 * 5. isEmpty returns boolean (top==-1)
 */


namespace BasicDataStructure
{
    [Serializable]public class MyStack
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

    /*
     * implement in array
     * 1. initial head and tail to -1
     * 2. Enqueue 
     * 3. Dequeue
     * 4. lastElement, FirstElement
     * 5. isEmpty
     */
    public class Queue
    {
        int front, end;
        string[] storage;

        public Queue(int iCapacity) 
        {
            front = -1;
            end = -1;
            storage = new string[iCapacity];
        }

        public bool enqueue(string sValue) {
            if (end < storage.Length-1)
            {
                end++;
                storage[end] = sValue;
                if (front == -1) front++;
                return true;
            }
            else {
                Console.WriteLine("the queue is full");
                return false;
            }
        }

        public bool dequeue() {
            if (front <= end&&front>-1)
            {
                storage[front] = "";
                front++;
                return true;
            }
            else {
                Console.WriteLine("the queue is empty");
                return false;
            }
        }

        public string sLastElement() {
            if (end < storage.Length && end > -1)
                return storage[end];
            else return "";
        }

        public string sFirstElement()
        {
            if (front < storage.Length && front > -1 && front<=end)
                return storage[front];
            else return "";
        }
    }



    public class LinkedListQueue<AnyType> 
    {
        Node<AnyType> front, end;
        
        public LinkedListQueue(AnyType aNode) {

            front = new Node<AnyType>(aNode, null);
            end = front;
        }

        public void enqueue(AnyType aNode){
            if (front == null)
            {
                front = new Node<AnyType>(aNode, null);
                end = front;
            }
            else
            {
                end.next = new Node<AnyType>(aNode, null);
                end = end.next;
            }
        }

        public Node<AnyType> dequeue()
        {
            if (front.next == null)
            {
                Node<AnyType> aNode = front;
                front = null;
                end = null;
                return aNode;
            }
            else {
                Node<AnyType> aNode = front;
                front = front.next;
                return aNode;
            }
        }

        public Node<AnyType> FrontNode()
        {
            return front;
        }

        public Node<AnyType> EndNode() {
            return end;
        }

        public void printNodes() {
            Node<AnyType> frontPointer = front;
            Node<AnyType> endPointer = end;

            while (frontPointer != endPointer)
            {
                Console.WriteLine(frontPointer.GetData());
                frontPointer = frontPointer.next;
            }

            if (frontPointer == endPointer) {
                Console.WriteLine(frontPointer.GetData());
            }
        }

        public bool isEmpty() {
            if (front == null && end == null) { return true; }
            else { return false; }
        }
        
    }
}
