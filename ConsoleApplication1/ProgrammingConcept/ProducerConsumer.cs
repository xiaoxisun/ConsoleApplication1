using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1.ProgrammingConcept
{
    class ProducerConsumer
    {
        private List<int> count;

        public ProducerConsumer()
        {
            count = new List<int>();
        }

        public void Producer()
        {
            lock (count)
            {
                Console.WriteLine("Producer start to add one more integer");
                count.Add(count.Count+1);
                Console.WriteLine("nodes left after produced:" + count.Count);
                Monitor.Pulse(count);
            }
        }

        public void Consumer()
        {
            while (true)
            {
                lock (count)
                {
                    Console.WriteLine("Consumer start to remove element from count if there is one");
                    while (count.Count == 0)
                    {
                        Monitor.Wait(count);
                    }
                    count.RemoveAt(count.Count - 1);
                    Console.WriteLine("nodes left after consume:" + count.Count);
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
