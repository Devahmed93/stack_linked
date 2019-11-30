using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_linkedlist
{
    class Node
    {
        int data;
        Node next;
        public Node(int value, Node n)
        {
            data = value;
            next = n;

        }

        public int Data { get => data; set => data = value; }
        internal Node Next { get => next; set => next = value; }
    }
}
