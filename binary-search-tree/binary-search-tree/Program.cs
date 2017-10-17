using binarySearchTree;
using System;

namespace binary_search_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(10);
            BinarySearchTree BST = new BinarySearchTree(root);

            BST.Traversal(root);

            Console.Read();
        }
    }
}
