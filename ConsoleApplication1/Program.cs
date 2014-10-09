using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;
using System.Threading;

//using MyNamespace;
using BasicDataStructure;
using MyNamespace;
using BasicAlgorithms;
using ConsoleApplication1.Practice;
using ConsoleApplication1.BasicAlgorithms;
using ConsoleApplication1.ProgrammingConcept;
using ConsoleApplication1.OOP;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            //Test Threading Producer and consumer. 
            ProducerConsumer aPC = new ProducerConsumer();

            Thread t1 = new Thread(aPC.Producer);

            Thread t2 = new Thread(aPC.Consumer);

          
            t2.Start();
            t1.Start();

            for (int i = 0; i < 10; i++)
            {
                aPC.Producer();
                Thread.Sleep(1000);
            }



            //test Dynamic binding
            //DynamicBinding D = new DynamicBinding();
            //RGB R = new RGB();
            //HSV H = new HSV();
            //DynamicBinding X = new HSV();

            //X = R;
            //X.GetBinaryMask();

            //List<string> result=Permutation.Perm("abc");
            //foreach (string s in result)
            //{
            //    Console.WriteLine(s);
            //}

            //
            //FloatVsDoubleVsDecimal.test();

            // test Dispose
            /*
            PractiseDisposeAndFinalize A = new PractiseDisposeAndFinalize();

            A.Write1();
            A.Dispose();
            
            using (PractiseDisposeAndFinalize B = new PractiseDisposeAndFinalize())
            {
                B.Write1();
            }
             */

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
            //DP
            //DynamicProgramming.test();
            
            //GetMedian
            //GetMedian myMedian = new GetMedian();
            //int test = myMedian.Selection(myMedian.A, 3);
            //Console.WriteLine("test="+test);
          
            //GetGCD
            //GCD myGCD = new GCD();
            //int nGCD=myGCD.GetGCD(999154,124583);
            //Console.WriteLine("nGCD=" + nGCD);
          
            //Primarity test 
            //  87178291199, 63018038201, 489133282872437279,19175002942688032928599
            // 160481183
            
            //IsPrime.IsPrimeSqrt(63018038201);
            //IsPrime.IsPrimeFermat(341);

            //test largest diff
            //BasicAlgorithms.LargestDiffBetweenTwoElementInMatrix A = new BasicAlgorithms.LargestDiffBetweenTwoElementInMatrix();
            //Console.WriteLine("The largest difference is:" + A.GetLargestDiff());


            //test matrix power 
           // MatrixPower A = new MatrixPower();
            //A.test();
            //A.PrintDiagonally();

            


            //int[] a = { 1, 2, 3 };
            //int[] b = a;
            //a[2] = 4;
            //Console.WriteLine("b2:" + b[2]);

            //test value 
            //int i = 1;
            //Console.WriteLine(0 & (1<<'b'-'a') );
            //char[] aC = { 'a', 'c', 'c' };
            //stringQuestions aQ = new stringQuestions();
            //aQ.sTest1 = "stest2 ";
            //aQ.sTest = "stest2 ";
            //Console.Write(aQ.sTest);

            /*
            Console.WriteLine("test point 0");
            tester_tryFinally();
            Console.WriteLine("test point 1");
            */

            /*
            Employee A = new Employee();
            Employee B = new Employee();
            employee C = new employee();

            Console.WriteLine(A.Equals(B));
            A._name = "Terry";
            A._age = 27;

            B._name = "Terry";
            B._age = 27;
            Console.WriteLine(A.GetHashCode());
            Console.WriteLine(B.GetHashCode());
            */

            //Dictionary<string, int>  dic=new Dictionary<string ,int>();
            //dic.Add("1",1);
            //dic.Add("1", 2);
            //Console.WriteLine(dic["1"]);
            //ReverseLinkedList Aclass = new ReverseLinkedList();

            //Aclass.reverse();
            //tester_ObserverPatter();

            //PractiseStack A = new PractiseStack();
            //A.Process();

            //int N = 4;
            //String alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //String elements = alphabet.Substring(0, N);

            ////// using first implementation
            ////comb1(elements);
            ////System.out.println();

            ////// using second implementation
            //BasicAlgorithms.Combinations.comb2(elements);

            //List<List<int>> A = BasicAlgorithms.Combinations.comb(4, 3);
            //foreach (List<int> B in A)
            //{
            //    foreach (int C in B)
            //    {
            //        Console.Write(C + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(BasicAlgorithms.Combinations.C(50, 25));

            //reverse a string 
            //string a = "abcd edf!";
            //string b=string.Empty;
            //string c = null;
            //if (c == ""||c==null) Console.WriteLine("hello");
            //foreach (char ch in a)
            //{
            //    b = ch + b;
            //    Console.WriteLine(b);
            //}

            //int remaider = -1 % 2;
            //double a = 1.00;
            //if (a==1)
            //    Console.WriteLine(a);



            System.Console.ReadKey();
        }

        static void tester_tryFinally() {
            ThrowTestB.Throwtest();
        }


        static void tester_ObserverPatterByDelegateAndEvent() {
            ConcretePublisher aPublisher = new ConcretePublisher();

           List<ConcreteSubscriber> A=new List<ConcreteSubscriber>();

           A.Add(new ConcreteSubscriber(aPublisher, "Jack"));

           A.Add(new ConcreteSubscriber(aPublisher, "John"));

           A.Add(new ConcreteSubscriber(aPublisher, "Rose"));
         
            aPublisher.notify();
        }




        static void tester_SingletonPatter1() {

            Singleton.GetInstance().DoIncreaseValue();
          
        }

        static void tester_ObserverPatter()
        {
            ConcreteSubject SolarCity = new ConcreteSubject();

            SolarCity.Attach(new ConcreteObserver(SolarCity, "Jack"));
            SolarCity.Attach(new ConcreteObserver(SolarCity, "Dani"));
            SolarCity.Attach(new ConcreteObserver(SolarCity, "John"));

            SolarCity.SubjectState = "news coming";
            SolarCity.Notify();

            SolarCity.SubjectState = "Malisia MH370 news coming, no Survivor.";
            SolarCity.Notify();
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

        //static void tester_LinkedList()
        //{
        //    LinkedList<string> A = new LinkedList<string>();

        //    //Test add
        //    A.addLast("test1");
        //    //A.addLast("test2"); 
        //    A.addLast("test2");
        //    A.addLast("test3");
        //    A.addLast("test4");

        //    //test print Nodes()
        //    A.printNodes();

        //    //test Delete
        //    //A.deleteNodeByContent("test4");
        //    //A.printNodes();

        //    //test revserse Linked list
        //    //A.reverseLinkedList();
        //   // A.printNodes();

        //    //test revserse Linked list

        //    A.headNode=A.reverseLinkedListRecursive(A.headNode);
        //   A.printNodes();
        //}

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
        


