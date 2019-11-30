using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Stacklist s = new Stacklist();
            s.push(1);
            s.push(2);
            s.push(3);
            s.push(4);
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.print();
        }
    }
}
