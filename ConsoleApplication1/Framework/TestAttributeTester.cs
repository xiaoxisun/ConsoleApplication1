using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Framework
{
   

        [Test(3)]
        public class TestClassA
        {
            public TestClassA()
            {
        
            }
        }

        [Test(4, Name = "TestClassB")]
        public class TestClassB
        {
            public TestClassB()
            {

            }
        }

    
}
