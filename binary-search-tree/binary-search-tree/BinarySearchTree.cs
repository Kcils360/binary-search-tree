using System;
using System.Collections.Generic;
using System.Text;

namespace binarySearchTree
{
    class BinarySearchTree
    {
        public Node newNode;

        public BinarySearchTree(Node value)
        {
            newNode = value;
        }
        
        

        public void Traversal(Node current)
        {
            if(newNode.Value < current.Value )
            {
                if(current.Left != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Left;
                }

            }
            else
            {
                if(current.Right != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Right;
                }

            }
        }
        public void Add(Node root, int value)
        {
            Node current = root;
            if (value < current.Value)
            {
                if (current.Left == null)
                {
                    current.Left = new Node(value);
                    return;
                }
                else
                {
                    Add(current.Left, value);
                    //return;
                }
            }
            if (value > current.Value)
            {
                if (current.Right == null)
                {
                    current.Right = new Node(value);
                    return;
                }
                else
                {
                    Add(current.Right, value);
                    //return;
                }
            }
        }

        public void Min(Node current)
        {
            while(current.Left != null)
            {
                current = current.Left;
            }
            if(current.Left == null)
            {
                Console.WriteLine(current.Value);
            }
        }

        public void Max(Node current)
        {
            if(current.Right == null)
            {
                Console.WriteLine(current.Value);
            }
            else
            {
                current.Right = current;
            }
            Max(current);
        }
    }
}
