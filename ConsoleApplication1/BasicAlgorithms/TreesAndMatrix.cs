using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNamespace;
using BasicDataStructure;
//
/*
 * Questions: There is a binary tree of size N. All nodes are numbered between 1 - N(inclusive). 
 * There is a N*N integer matrix Arr[N][N], all elements are initialized to zero. 
 * So for all the nodes A and B, put Arr[A][B] = 1 if A is an ancestor of B (NOT just the immediate ancestor).
 * 
 * level order traverse.
 * 
 * be careful with index
 */
namespace ConsoleApplication1.BasicAlgorithms
{
    class TreeAndMatrix
    {
        public BinaryTree Root=new BinaryTree();

        public TreeAndMatrix() 
        {
 
        }


        public void generateMatrix(BinaryTree root, int N)
        {
            //start from root and go level order tranverse(width first tranverse)
           // need a queen. 
            Queue aQueue = new Queue(N);


        }
        
    }
}
