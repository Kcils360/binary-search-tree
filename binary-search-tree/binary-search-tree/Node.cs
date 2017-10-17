using System;
using System.Collections.Generic;
using System.Text;

namespace binarySearchTree
{
    class Node
    {

        public int Value;
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
        
    }
}
