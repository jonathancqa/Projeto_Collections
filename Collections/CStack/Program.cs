using System;
using System.Collections.Generic;

namespace CStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Pilha de Livros ===");

            Stack<string> stack = new Stack<string>();

            stack.Push(new string("Harry Potter e a Pedra Filosofal"));
            stack.Push(new string("Game of Thrones: A Guerra dos Tronos"));
            stack.Push(new string("Senhor dos Anéis: A Sociedade do Anel"));

            Console.WriteLine($"Quantidade de livros na pilha: {stack.Count}");

            Console.WriteLine($"Primeiro livro do topo: {stack.Peek()}");
            stack.Pop();

            foreach (string livros in stack)
            {
                Console.WriteLine($"Aqui está o Livro: {livros}");
            }
            
        }
        
    }
}
