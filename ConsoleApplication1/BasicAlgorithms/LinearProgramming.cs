using System;

/*
 * 
 * What is the most typical linear programming problem. 
 * 
 * get maximum profit x1 + 6x2
 * 
 * Where x1<=200, x2<=300, x1 + x2 <= 400, x1,x2>0
 * 
 * Simplex Method, devised by George Dantzig in
1947.
 * 
 * but briefly, this algorithm starts at a
vertex, in our case perhaps (0; 0), and repeatedly looks for an adjacent vertex (connected by
an edge of the feasible region) of better objective value. In this way it does hill-climbing on
the vertices of the polygon, walking from neighbor to neighbor so as to steadily increase prot
along the way. Here's a possible trajectory.
 * 
 * 
 * how about 3D 
 * x1+6x2+13x3
 * 
 * In a typical application, the main task is therefore to correctly express
the problem as a linear program. The package then takes care of the rest.
 * 
 * */
namespace BasicDataStructure
{
    public class LinearProgramming 
    {
        public LinearProgramming()
        {
 
        }

        public static void test()
        {
          
        }


        
    }//End of class
}
