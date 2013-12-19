using System;

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

    public class Node<AnyType>
    {
        private AnyType data;
        public Node<AnyType> next;

        public Node(AnyType data, Node<AnyType> next)
        {
            this.data = data;
            this.next = next;
        }

        public AnyType GetData() 
        {
            return data;
        }

    }

    /// <summary>
    /// LinkedList. implement using Node Class
    /// 1. addLast
    /// 2. printNodes
    /// 3. deleteNode
    /// </summary>
    ///
    public class LinkedList<AnyType>
    {
        public Node<AnyType> headNode;
        public Node<AnyType> lastNode;

        public void addLast(AnyType item)
        {
            if (headNode == null)
            {
                headNode = new Node<AnyType>(item, headNode);
                lastNode = headNode;
            }
            else
            {
                Node<AnyType> tmp = headNode;
                while (tmp.next != null) tmp = tmp.next;
                tmp.next = new Node<AnyType>(item, null);
            }
        }
        
        
        public void printNodes()
        {
            Node<AnyType> currentNode = headNode;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.GetData());//? becareful with type
                currentNode = currentNode.next;
            }

        }


        public void deleteNode(Node<AnyType> n)
        {
            Node<AnyType> CurrentNode, PreviousNode;//

            if (headNode == null) {
                return;
            }else 
            {
                while(n==headNode){
                    headNode = headNode.next;
                }

                CurrentNode = headNode;
                PreviousNode = null;
                Console.WriteLine("test point B");
                
                while (CurrentNode != null)
                {
                    if (n == CurrentNode)
                    {
                        PreviousNode.next = CurrentNode.next;//remove the current node, and re-pointing previous node from current to current-->next.
                        CurrentNode = CurrentNode.next;
                        Console.WriteLine("test point C");
                    }
                    else
                    {
                        PreviousNode = CurrentNode;
                        CurrentNode = CurrentNode.next;
                        Console.WriteLine("test point D");
                    }
                    Console.WriteLine("test point F");
                }
            }
        }

        /// <summary>
        /// Delete node by compare the centent 
        /// case: 
        /// 1. Begining: 
        ///    a. head is null;  return
        ///    b. head is not null; head=head.next
        /// 2. Middle:
        ///    previous.next=current.next;
        ///    current=current.next
        /// 3. End:(this case can belong to 2 Middle because when current comes to the end node, 
        ///     previous.next=current.next=null, current=current.next=null)
        ///    set previous to null
        ///    set current to null
        /// </summary>
        ///
        public void deleteNodeByContent(AnyType content)
        {
            Node<AnyType> CurrentNode, PreviousNode;//

            if (headNode == null)
            {
                return;
            }
            else
            {
                while (content.ToString() == headNode.GetData().ToString())
                {
                    headNode = headNode.next;
                }

                CurrentNode = headNode;
                PreviousNode = null;
                
                while (CurrentNode != null)
                {
                    if (content.ToString() == CurrentNode.GetData().ToString())
                    {
                        PreviousNode.next = CurrentNode.next;//remove the current node, and re-pointing previous node from current to current-->next.
                        CurrentNode = CurrentNode.next;
                    }
                    else
                    {
                        PreviousNode = CurrentNode;
                        CurrentNode = CurrentNode.next;
                    }
                }
            }

        }
  

        public void reverseLinkedList() //non recursive
        {
            Node<AnyType> previousNode, currentNode, nextNode;

            if (headNode == null)
            {
                return;
            }
            else {   
                previousNode = null;
                currentNode = headNode;
             
                while (currentNode != null)
                {
                    nextNode = currentNode.next;
                    currentNode.next = previousNode;
                    previousNode = currentNode;
                    currentNode = nextNode;
                }
                headNode = previousNode;
                return;
            }
        }


        public Node<AnyType> reverseLinkedListRecursive(Node<AnyType> firstNode)
        {
            if (firstNode == null || firstNode.next == null)
            {
              //  Console.WriteLine(firstNode.GetData());
                return firstNode;
            }


            /*
             * 1. get seconde node
             * 2. first node pointing to null
             * 3. recursively to seconde node
             * 4. second next pointing back to first node
             */
            Node<AnyType> secondNode = firstNode.next;
            firstNode.next = null; 
            Node<AnyType> restNode = reverseLinkedListRecursive(secondNode);
            secondNode.next = firstNode;
            // Console.WriteLine(firstNode.GetData());
            return restNode;
        }
        /*
        public iterator<AnyType> iterator() { 
        return new 
        }
        */
    }//end of class LinkedList
      


    /*
     * Given a circular linked list, implement an algorithm which returns node at the beginning of the loop.
     * DEFINITION
     * Circular linked list: A (corrupt) linked list in which a node’s next pointer points to an earlier node, so as to make a loop in the linked list.
     * EXAMPLE:
     * input: A -> B -> C -> D -> E -> C [the same C as earlier]
     * output: C
    */

    public class CircularlinkedList<AnyType> : LinkedList<AnyType>
    {
        public void GetLoopHead() { 
            
        }

       
    }
    


    public class BTNode<AnyType>
    {
        public BTNode<AnyType> left;
        public BTNode<AnyType> right;
        private AnyType data;
        public string name;

        // Constructor  to create a single node 
        public BTNode(AnyType data, string name)
        {
            this.name = name;
            this.data = data;
            left = null;
            right = null;
        }

        public AnyType GetData()
        {
            return data;
        }
    }


}
