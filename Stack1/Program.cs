using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack A = new Stack();
            A.Push(1);
            A.Push(2);
            A.Push(4);
            A.Push(5);
            A.Push(6);
            A.Push(7);
            A.Push(3);
            A.Pop();
            A.Pop();
            A.Pop();
            A.Pop();
            A.Pop();
            A.view();
            Console.ReadKey();
        }
    }
}
