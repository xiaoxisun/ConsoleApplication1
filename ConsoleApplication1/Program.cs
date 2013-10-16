using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;
using System.Threading;

//using MyNamespace;
using BasicDataStructure;
using MyNamespace;
using BasicAlgorithms;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
           // tester_LinkedList();
           // tester_BinaryTree();
            //
            
            //tester_primeNumber();
            /*
            Thread myTreadOne;
            Thread myTreadTwo;

            myTreadOne = new Thread(new ThreadStart(tester_SingletonPatter1));
            myTreadTwo = new Thread(new ThreadStart(tester_SingletonPatter2));

            myTreadOne.Start();
            myTreadTwo.Start();
            */
            /*
            string a = "test is (XXX)";
            string v=a.Replace("XXX", "02 Januray 2012");
            Console.WriteLine(a[13]);
            */

            //sortArray
            //sortArray.Test();

            //DP
            //DynamicProgramming.test();

            //GetMedian
            //GetMedian myMedian = new GetMedian();
            //int test = myMedian.Selection(myMedian.A, myMedian.A.Length/2);
            //Console.WriteLine("test="+test);
          
            //GetGCD
            //GCD myGCD = new GCD();
            //int nGCD=myGCD.GetGCD(999154,124583);
            //Console.WriteLine("nGCD=" + nGCD);
          
            //Primarity test 
            //  87178291199, 63018038201, 489133282872437279,19175002942688032928599
            // 160481183
            //IsPrime.IsPrimeSqrt(63018038201);
            IsPrime.IsPrimeFermat(341);

            /*
            Console.WriteLine("test point 0");
            tester_tryFinally();
            Console.WriteLine("test point 1");
            */
            System.Console.ReadKey();
        }

        static void tester_tryFinally() {
            ThrowTestB.Throwtest();
        }


        static void tester_ObserverPatterByDelegateAndEvent() {
            ConcretePublisher aPublisher = new ConcretePublisher();

            new ConcreteSubscriber(aPublisher, "Jack");

            new ConcreteSubscriber(aPublisher, "John");

            new ConcreteSubscriber(aPublisher, "Rose");

            aPublisher.notify();
        }


        static void tester_ObserverPatter() { 
            ConcreteSubject SolarCity=new ConcreteSubject();

           SolarCity.Attach(new ConcreteObserver(SolarCity,"Jack"));
           SolarCity.Attach(new ConcreteObserver(SolarCity, "Dani"));
           SolarCity.Attach(new ConcreteObserver(SolarCity, "John"));

            SolarCity.SubjectState = "news coming";
            SolarCity.Notify();
        }

        static void tester_SingletonPatter1() {

            Singleton.GetInstance().DoIncreaseValue();
          
        }


        static void tester_SingletonPatter2()
        {
            Singleton.GetInstance().DoDecreaseValue();
            /*
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Decreased Value is :" + Singleton.GetInstance().DecreaseValue());
            }
             * */
        }

        static void tester_primeNumber()
        {
            NumbersChecker.Test();
        }
        

        static void tester_hashTable() {
          
            HashTable aHash = new HashTable(20);
            aHash.Add("test","a");
            aHash.Add("John", "b");
            aHash.Add("Terry", "c");

            Console.WriteLine(aHash.Get("test"));
            Console.WriteLine(aHash.Get("John"));
            Console.WriteLine(aHash.Get("Terry"));
        }

        static void tester_LinkedList()
        {
            LinkedList<string> A = new LinkedList<string>();

            //Test add
            A.addLast("test1");
            //A.addLast("test2"); 
            A.addLast("test2");
            A.addLast("test3");
            A.addLast("test4");

            //test print Nodes()
            A.printNodes();

            //test Delete
            //A.deleteNodeByContent("test4");
            //A.printNodes();

            //test revserse Linked list
            //A.reverseLinkedList();
           // A.printNodes();

            //test revserse Linked list

            A.headNode=A.reverseLinkedListRecursive(A.headNode);
           A.printNodes();
        }

        static void tester_BinaryTree() 
        {
              Console.WriteLine("Hello");
              BinaryTree aTree = new BinaryTree();

              aTree.insert("A", 50);
             // Console.WriteLine(aTree.insert("test",50).data);
            
              aTree.insert("B", 40);

            //  aTree.drawTree();
                     
              aTree.insert("C", 60);
              aTree.insert("D", 30);
              aTree.insert("E", 45);
              aTree.insert("F", 20);
              aTree.insert("G", 35);
              aTree.insert("H", 44);
              aTree.insert("I", 46);

              aTree.inorderTraverse(aTree.GetRoot());
              Console.WriteLine(aTree.isBST(aTree.GetRoot()));
        }


        void tester2()
        {
            /*
                  Node NodeA = new Node("test1");
            LinkedListQueue A = new LinkedListQueue(NodeA);
            
            A.printNodes();

            A.enqueue(NodeA);
            A.printNodes();

            A.enqueue(NodeA);
            A.printNodes();

            A.enqueue(NodeA);
            A.printNodes();


            LinkedList<>
            /*
            for (int i = 0; i < 20; i++)
            {
                Node aNode = new Node("test" + i);
                A.enqueue(aNode);
                Console.WriteLine("Front:"+A.FrontNode().data);
                Console.WriteLine("End:"+A.EndNode().data);
            }

            A.dequeue();
            A.dequeue();
            A.dequeue();
            Console.WriteLine("======>Front:" + A.FrontNode().data);
            Console.WriteLine("End:" + A.EndNode().data);

            Console.WriteLine("====================");
            LinkedList B = new LinkedList();
            Node Node1 = new Node("test1");
            Node Node2 = new Node("test2");
            Node Node3 = new Node("test3");
            B.add(Node1);
            B.add(Node1);

            */
            //B.add(Node1);
            //B.add(Node2);
            //B.add(Node3);
            //B.printNodes();
           // B.printNodes();
           // B.deleteNode(Node3);
           //B.printNodes();
            /*
            LinkedList A = new LinkedList();
            for (int i = 0; i < 20;i++ )
            {
                Node aNode=new Node("test"+i);
                A.add(aNode);
                A.printNodes();
            }
            */
            
            /*
            Queue A = new Queue(20);
            for (int i = 0; i < 21; i++)
            {
                A.enqueue("test "+i);
                Console.WriteLine("sLastElement=" + A.sLastElement());
                Console.WriteLine("sFirstElement=" + A.sFirstElement());
                Console.WriteLine("==================================");
            }
            */

            //Test stack
            /*
            MyStack A = new MyStack(20);
            A.push("test1");
            Console.WriteLine(A.peak());
            A.push("test2");
            Console.WriteLine(A.peak());
            A.push("test3");
            Console.WriteLine(A.peak());
            A.pop();
            A.pop();
            A.pop();
            A.pop();
            Console.WriteLine(A.peak());
            */
       /*
            
      A.dequeue();
      Console.WriteLine("sLastElement=" + A.sLastElement());
      Console.WriteLine("sFirstElement=" + A.sFirstElement());
      Console.WriteLine("==================================");
      A.dequeue();
      Console.WriteLine("sLastElement=" + A.sLastElement());
      Console.WriteLine("sFirstElement=" + A.sFirstElement());
      Console.WriteLine("==================================");
      A.dequeue();
      Console.WriteLine("sLastElement=" + A.sLastElement());
      Console.WriteLine("sFirstElement=" + A.sFirstElement());
      Console.WriteLine("==================================");
      A.dequeue();
      Console.WriteLine("sLastElement=" + A.sLastElement());
      Console.WriteLine("sFirstElement=" + A.sFirstElement());
      Console.WriteLine("==================================");
      A.dequeue();
      Console.WriteLine("sLastElement=" + A.sLastElement());
      Console.WriteLine("sFirstElement=" + A.sFirstElement());
      Console.WriteLine("==================================");
      */
       
        }
    

    }


   
}
        


