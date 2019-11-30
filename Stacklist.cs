using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_linkedlist
{
    class Stacklist
    {
        Node head = null;
        int count = 0;
        public int size()
        {
            return count;

        }
        public bool isEmpty()
        {
            if (count == 0)
            {
                return true;


            }
            else
            {
                return false;
            }
        }
        public int peak()
        {
            if (isEmpty())
            {
                Console.WriteLine("list is empty");
                return 0;

            }
            return head.Data;

        }
        public void push(int data)
        {
            head = new Node(data, head);
            count++;
        }
        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("list is empty");
                return 0;

            }
            int value = head.Data;
            head = head.Next;
            count--;
            return value;

        }
        public void print()
        {
            if (isEmpty())
            {
                Console.WriteLine("list is empty");
                return;

            }
            
            Node temp = head;
            while (temp!=null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

        }
    }
}
