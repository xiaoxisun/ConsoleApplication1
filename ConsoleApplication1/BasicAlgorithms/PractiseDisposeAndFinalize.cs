using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1.BasicAlgorithms
{
    class PractiseDisposeAndFinalize:IDisposable
    {

        public void Write1()
        {
            
            Console.WriteLine("Important data line 1");
            
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose called");
        }
    }


}
