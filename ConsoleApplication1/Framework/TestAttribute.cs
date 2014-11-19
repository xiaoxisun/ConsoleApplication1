using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Framework
{

    public class TestAttribute : Attribute
    {
        public int TheNumber;

        public string Name;

        public TestAttribute(int number)
        {
            TheNumber = number;
        }

        public void PrintOut()
        {
            Console.WriteLine("\tTheNumber = {0}", TheNumber);
            Console.WriteLine("\tName = \"{0}\"", Name);
        }
    }
}
