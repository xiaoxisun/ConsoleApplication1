using System;

using System.Diagnostics;
using System.Threading;
using MyNamespace;
using BasicDataStructure;
/// <summary>
/// array-based string stack 
/// </summary>
///

namespace MyNamespace
{
    class StatusChecker
    {
        int invokeCount, maxCount;

        public StatusChecker(int count)
        {
            invokeCount = 0;
            maxCount = count;
        }

        // This method is called by the timer delegate.
        public void CheckStatus(Object stateInfo)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;
            Console.WriteLine("{0} Checking status {1,2}.",
                DateTime.Now.ToString("h:mm:ss.fff"),
                (++invokeCount).ToString());

            if (invokeCount == maxCount)
            {
                // Reset the counter and signal Main.
                invokeCount = 0;
                autoEvent.Set();
            }
        }

        public void Tester1()
        {
            AutoResetEvent reset = new AutoResetEvent(false);
            StatusChecker status = new StatusChecker(5);

            // Invoke methods for the timer via a Delegate
            TimerCallback timerDelegate = new TimerCallback(status.CheckStatus);

            // Create a timer that signals the delegate to invoke 
            // Check status after one second, and then every 1/4 second
            Console.WriteLine("{0} Creating the timer.\n", DateTime.Now.ToString("h:mm:ss.fff"));
            Timer stateTimer = new Timer(timerDelegate, reset, 1000, 250);

            // When the auto reset executes, change to every 1/2 second
            reset.WaitOne(5000, false);
            stateTimer.Change(0, 500);
            Console.WriteLine("\nChanging the timer period.\n");

            reset.WaitOne(5000, false);
            stateTimer.Dispose();
            Console.WriteLine("\nDestroying the timer.");
            System.Console.ReadKey();
        }
    }
}
