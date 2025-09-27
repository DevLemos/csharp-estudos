using System;
using System.Collections.Generic;

namespace stack_heap
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack();
            Heap();
        }

        //Stack
        public static void Stack()
        {
            Stack<int> stack = new Stack<int>();

            Console.WriteLine("Stack iniciando... \n");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
            {
                Console.WriteLine($"- {stack.Pop()}");
            }
            Console.WriteLine("\nStack finalizada...\n");
        }

        //Heap
        class Pessoa
        {
            public string Nome { get; set; }
        }

        public static void Heap()
        {
            Console.WriteLine("Heap iniciando... ");

            Pessoa p1 = new Pessoa();
            p1.Nome = "Michael";

            Console.WriteLine($"Nome Pessoa: {p1.Nome}\n");

            Pessoa p2 = p1;
            p2.Nome = "João";

            Console.WriteLine("Heap finalizada...");
            Console.WriteLine($"Nome Pessoa: {p1.Nome}\n");
        } 
    }
}

