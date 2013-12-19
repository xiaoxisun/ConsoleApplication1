using System;
using BasicDataStructure;
using System.Collections;
/// <summary>
/// Simple thread safe singleton pattern  
/// A Singleton patter is a design pattern which makes a instance of a class globally available and guarantee that only one instance of the class is created. 
/// </summary>
///

namespace MyNamespace
{
    public class Singleton
    {
        private static Singleton instance;// a key word makes it globally
        static readonly object padlock=new object();

        private Singleton() //a private constructor so that nobody else outside the class can make a copy of this, can instantiate it
        { 
        }


        public static Singleton GetInstance() //exposes an instance of itself by a public static property; if the instance does not exist yet, instantiates one.
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

        /*
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
