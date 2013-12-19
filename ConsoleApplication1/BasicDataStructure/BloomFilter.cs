using System;

/*

 * */
namespace BasicDataStructure
{
    public class Bloomfilter 
    {
        int n;
        double p;
        public byte[] M; 

        public Bloomfilter(int nObjects, double FalsePositiveRate) {
            p = FalsePositiveRate;
            n = nObjects;
            double m = -n * Math.Log(p, Math.E)/Math.Log(2,Math.E);

        }

        
    }

}
