using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication1.Framework;

namespace ConsoleApplication1.Framework
{
           public class Driver
        {
               //public static void Main(string[] Args)
               //{
               //    TestClassA a = new TestClassA();
               //    TestClassB b = new TestClassB();
               //    string c = "";

               //    PrintTestAttributes(a);
               //    PrintTestAttributes(b);
               //    PrintTestAttributes(c);
               //}

//               How it works

//All of the work is done by the framework with the call to GetCustomAttributes on the Type object. 
//GetCustomAttributes takes two parameters, the first is a Type object for the attribute we wish to get, the second is a boolean telling the framework whether it should look at the types that this class derives from.  GetCustomAttributes returns an object array containing each of the attributes found that match the Type passed in.  In this case we requested all attributes of a specific type, so we can safely cast that to an array of our attribute.  At the very least we could cast that to an array of Attribute's.  If you wish to get all attributes attached to a type you just pass in value for the bool.

//If you look up the GetCustomAttributes method you'll see that it is defined on the MemberInfo class.  This class is an abstract class which has several derivatives; Type, EventInfo, MethodBase, PropertyInfo, and FieldInfo.  Each of those classes represents a part of the very basics for the type system.  Right now the TestAttribute can be applied to all those parts of a class, what if TestAttribute only makes sense to be applied to classes?  Enter the AttributeUsage attribute. 

//Once it has gotten an array of TestAttribute's it determines how many are in the array; if there are none in the array we know that the class doesn't have the TestAttribute applied to it; else we take the first one in the array and tell it to output its values by the PrintOut method we created in the TestAttribute class.

            public static void PrintTestAttributes(object obj)
            {
                Type type = obj.GetType();

                TestAttribute[] AttributeArray =
                   (TestAttribute[])type.GetCustomAttributes(typeof(TestAttribute),
                                                               false);

                Console.WriteLine("Class:\t{0}", type.Name);
                if (AttributeArray.Length == 0)
                {
                    Console.WriteLine("There are no TestAttributes applied to this class {0}",
                                      type.Name);
                    return;
                }

                TestAttribute ta = AttributeArray[0];

                ta.PrintOut();
            }
        }
    
}
