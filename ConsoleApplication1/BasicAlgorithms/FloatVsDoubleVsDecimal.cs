using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.BasicAlgorithms
{
    class FloatVsDoubleVsDecimal
    {
        static float aF; // 32 bits 4 bytes
        static double aD; //64 bits 8 bytes
        static decimal aDec; //128 bit 16 bytes

        public static void test()
        {
          
            aF = 1.5F;
            int x = 1;
            //
            int y=  5 + x - (x += (1+1));
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            // for a evalution formuler. (++x) does not effect the first x. 
            // see below example. 
            Console.WriteLine(x - (++x));

            Console.WriteLine(x);
            Console.WriteLine((x+1)*aF);


            short p=20000;
            short q=400;
            int K=p*q;

            Console.WriteLine(p * q);

        }


    }
}
