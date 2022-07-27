using System;
using System.Collections;
using System.Collections.Generic;

namespace CQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Fila de Pessoas ===");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();


            pessoas.Enqueue(new Pessoa("Jonathan"));
            pessoas.Enqueue(new Pessoa("Gabriel"));
            pessoas.Enqueue(new Pessoa("Amanda"));
            pessoas.Enqueue(new Pessoa("Reynald"));
            pessoas.Enqueue(new Pessoa("Israel"));

            Console.WriteLine($"A primeira Pessoa da fila é: {pessoas.Dequeue()}");
            
            pessoas.Peek();

            Console.WriteLine($"A quantidade de pessoas ainda na fila: {pessoas.Count}");

            foreach(Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }

        }


        public class Pessoa
        {
            public string Nome { get; set; }

            public Pessoa(string nome)
            {
                Nome = nome;
            }

            public override string ToString()
            {
                return $"Nome da Pessoa: {Nome}";
            }
        }
        

    }
}
