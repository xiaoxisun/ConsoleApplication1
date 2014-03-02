using System;
using BasicDataStructure;
using System.Collections;
/// <summary>
/// Simple thread safe singleton pattern  
/// A Singleton patter is a design pattern which makes a instance of a class globally available and guarantee 
/// that only one instance of the class is created. 
/// </summary>
///

namespace MyNamespace
{
    public class Singleton
    {
        private static Singleton instance;// a key word makes it globally
        static readonly object padlock=new object();

        private Singleton() 
        //a private constructor so that nobody else outside the class can make a copy of this, can instantiate it
        { 

        }



        /* //for single thread/
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        */

        //private static readonly Lazy<Singleton> mySingleton= new Lazy<Singleton>();

        //private Singleton()
        //{
 
        //}

        //public static Singleton Instance
        //{
        //    get
        //    {
        //        return mySingleton.Value;
        //    }
        //}

        //double-checked locking has subtle problems. avoid using this. 
        public static Singleton GetInstance()
        //exposes an instance of itself by a public static property; if the instance does not exist yet, instantiates one.
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }

                }
            }
            return instance;
        }


        //Lazy 


        /*
1) Which classes are candidates of Singleton? Which kind of class do you make Singleton in Java?
Here they will check whether candidate has enough experience on usage of singleton or not. Does he is familiar 
         * of advantage/disadvantage or alternatives available for singleton in Java or not.
Answer: Any class which you want to be available to whole application and whole only one instance is viable is candidate 
         * of becoming Singleton. One example of this is Runtime class , since on whole java application only one runtime
         * environment can be possible making Runtime Singleton is right decision. Another example is a utility classes 
         * like Popup in GUI application, if you want to show popup with message you can have one PopUp class on whole
         * GUI application and anytime just get its instance, and call show() with message.
         * 
        2) Can you write code for getInstance() method of a Singleton class in Java?
Most of the java programmer fail here if they have mugged up the singleton code because you can ask 
         * lots of follow-up question based upon the code they have written. I have seen many programmer 
         * write Singleton getInstance() method with double checked locking but they are not really familiar 
         * with the caveat associated with double checking of singleton prior to Java 5.
Answer: Until asked don’t write code using double checked locking as it is more complex and chances of errors 
         * are more but if you have deep knowledge of double checked locking, volatile variable and lazy loading
         * than this is your chance to shine. I have shared code examples of writing singleton classes using enum, 
         * using static factory and with double checked locking in my recent post Why Enum Singletons are better 
         * in Java, please see there.


Read more: http://javarevisited.blogspot.com/2011/03/10-interview-questions-on-singleton.html#ixzz2rF06a1CL

Read more: http://javarevisited.blogspot.com/2011/03/10-interview-questions-on-singleton.html#ixzz2rEwvsuHl
         * */


        private int count = 0;
        public int IncreaseValue() {
            return ++count;
        }

        public int DecreaseValue()
        {
            return --count;
        }

        public void DoIncreaseValue() {
            lock (padlock)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Increased Value is :" + Singleton.GetInstance().IncreaseValue());
                }
            }
            
        }

        public void DoDecreaseValue()
        {
            lock (padlock)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Increased Value is :" + Singleton.GetInstance().DecreaseValue());
                }
            }
        }
    }
}
