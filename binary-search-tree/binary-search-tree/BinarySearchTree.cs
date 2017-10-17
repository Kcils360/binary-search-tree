using System;
using System.Collections.Generic;
using System.Text;

namespace binarySearchTree
{
    class BinarySearchTree
    {
        public Node newNode;
        public Node root;
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
                    current = current.Left;
                }
                else
                {
                    current.Left = newNode;
                }
            }
            else
            {
                if(current.Right != null)
                {
                    current = current.Right;
                }
                else
                {
                    current.Right = newNode;
                }
            }
        }
    }
}
