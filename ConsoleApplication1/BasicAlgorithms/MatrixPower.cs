using System;

/*   
 * 1. regular O(n^3)
 * 
 * 
 * 2. divide and conquer O(n^2.817) ???
 * 
 * */

namespace BasicAlgorithms
{
    public class MatrixPower
    {
         //declare matrix as two dimentional array, 
        private static int[,] aMatrix;
        public int[,] aResultMatrix;

        public MatrixPower()//constructor
        {
            aMatrix=new int[,]
            {
                {0,1,0,0},
                {0,0,0,0},
                {0,1,0,1},
                {1,0,0,0},
            };

            aResultMatrix = new int[aMatrix.GetLength(0), aMatrix.GetLength(1)];
 
        }

        public void test()
        {
            MatrixPowerOperation(1);


            //print out matrix
            for (int i = 0; i < aResultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < aResultMatrix.GetLength(1); j++)
                {
                    Console.Write(aResultMatrix[i, j].ToString() + " ");
                }
                Console.Write("\n");
            }
        }

        public void MatrixPowerOperation(int n)
        {
            if (n == 1) return;

            int k = 1;
            int[,] aTempMatrix = (int[,])aMatrix.Clone();

            Console.WriteLine("aMatrix.GetLength(1)"+aMatrix.GetLength(0));

            while (k < n && n>1)
            {
                ////aTempMatrix = (int[,]) aResultMatrix.Clone();
                if (k > 1) aTempMatrix = (int[,])aResultMatrix.Clone();

                for (int i = 0; i < aMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < aMatrix.GetLength(1); j++)
                    {
                        int tempSum = 0;
                        int p = 0;
                        int q = 0;

                        while (p < aMatrix.GetLength(0) && q < aMatrix.GetLength(1))
                        {

                            //Console.Write("[" + i + " " + q + "(" + aTempMatrix[i, q] + "), " + p + " " + j + " (" + aMatrix[p, j] + ")]");
                            tempSum += aTempMatrix[i, q] * aMatrix[p, j];
                            p++;
                            q++;
                        }

                        aResultMatrix[i, j] = tempSum;
                        //Console.Write("\n");
                    }
                }
                k++;
            }
        }

         
    }

}
