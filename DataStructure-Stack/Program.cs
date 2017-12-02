using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<object> stack = new Stack<object>();
            stack.Push(20);
            stack.Push(2);
            stack.Push(30);
            stack.Push("a string");
            stack.Push("another string");
            Console.WriteLine("Items in stack: {0}", stack.Count);
            foreach(var item in stack)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine("POP");
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine("");
            Console.WriteLine("After POP");
            Console.WriteLine("Items in stack: {0}", stack.Count);
            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine("Peek");
            Console.WriteLine(stack.Peek().ToString());
            Console.WriteLine("");
            Console.WriteLine("After Peek");
            Console.WriteLine("Items in stack: {0}", stack.Count);
            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());
            }

            Console.Read();
        }
    }
}
