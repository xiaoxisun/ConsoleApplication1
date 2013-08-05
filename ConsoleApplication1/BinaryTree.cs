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
    // The Binary tree itself
    /*questions to be answer:
     * Is duplicate allowed, if so, how does it work? 
     * how to change to BST, and how to validate it is a BST. 
     * how to do BFS, DFS, 
     * tranverse.
     */    
    public class BinaryTree 
    {

        // Implements:

        // count()
        // clear()
        // insert()
        // delete()
        // findSymbol()
        //
        // Usage:
        //
        //  BinaryTree bt = new BinaryTree();
        //  bt.insert ("Bill", "3.14");
        //  bt.insert ("John". 2.71");
        //  etc.
        //  node = bt.findSymbol ("Bill");
        //  WriteLine ("Node value = {0}\n", node.value);
        //
        private BTNode<int> root;
        private int _count = 0;

        public BTNode<int> GetRoot() {
            return root;
        }

        public BinaryTree()
        {
            root = null;
            _count = 0;
        }

        /// <summary>
        /// Returns the number of nodes in the tree
        /// </summary>
        /// <returns>Number of nodes in the tree</returns>
        public int count() {
            return _count;
        }

        // Recursively locates an empty slot in the binary tree and inserts the node
        private void add(BTNode<int> node, ref BTNode<int> root)
        {
            if (root == null)
                root = node;
            else {
                if (node.GetData() == root.GetData()) throw new Exception();

                if (node.GetData() < root.GetData()) add(node, ref root.left);
                else add(node,ref root.right);
            }
        }

        /// <summary>
        /// Add a symbol to the tree if it's a new one. Returns reference to the new
        /// node if a new node inserted, else returns null to indicate node already present.
        /// </summary>
        /// <param name="name">Name of node to add to tree</param>
        /// <param name="d">Value of node</param>
        /// <returns> Returns reference to the new node is the node was inserted.
        /// If a duplicate node (same name was located then returns null</returns>
        public BTNode<int> insert(string name, int data) {
            BTNode<int> aNode = new BTNode<int>(data, name);
            try
            {
                if (root == null)
                {
                    root = aNode;
                    return root;
                }
                else
                {   //
                    _count++;
                    add(aNode,ref root);
                    return aNode;
                }
            } catch(Exception){
                return null;
            }
        }

        /// <summary>
        /// BFS, visit root node.
        /// 1. visit root, if root is null, quit. 
        /// 2. visit left child node, enqueue left child node if data exit. 
        /// 3. visit right child node, enqueue right child node if data exit. 
        /// 4. dequeue a node, print it and repeat step 2 and 3. 
        /// </summary>
        /// <returns>print tree</returns>
        public void drawTree()
        {   
            if (root == null) { Console.WriteLine("Tree is empty");  }
            else {
                LinkedListQueue<BTNode<int>> A = new LinkedListQueue<BTNode<int>>(root);

                while (A.isEmpty() != true)
                {
                    Node<BTNode<int>> aNode = A.dequeue();
                    Console.WriteLine(aNode.GetData().GetData().ToString());
                    if (aNode.GetData().left !=null)
                        A.enqueue(aNode.GetData().left);
                    if (aNode.GetData().right != null)
                        A.enqueue(aNode.GetData().right);
                }
            }
        }


        /// <summary>
        /// inorder
        /// </summary>
        /// <returns>print tree</returns>
        public void inorderTraverse(BTNode<int> node)
        {
            if (node == null) { return; }
            else
            {
                inorderTraverse(node.left);
                Console.WriteLine(node.GetData().ToString());
                inorderTraverse(node.right);
                return;
            }
        }

        static BTNode<int> prev = null;

        public bool isBST(BTNode<int> node)
        {
            if (node!=null) 
            {
                // traverse the tree in inorder fashion and keep track of prev node
                if (!isBST(node.left)) return false;

                if (prev != null && node.GetData() <= prev.GetData())  return false; 

                prev = node;

                if (!isBST(node.right)) return false;
            }
            return true;
        }

    }

}
