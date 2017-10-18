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

            BST.Add(root, 7);
            BST.Add(root, 12);
            BST.Add(root, 8);
            BST.Add(root, 3);
            BST.Add(root, 13);
            BST.Add(root, 15);

            BST.Traversal(root);
            //BST.Min(root);
            //BST.Max(root);

            Console.Read();
        }
    }
}
