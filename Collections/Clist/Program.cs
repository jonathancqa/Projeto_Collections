using System;
using System.Collections.Generic;

namespace Clist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Lista de Animais ===");
            List<string> Animais = new List<string>();

            Animais.Add("Gato"); 
            Animais.Add("Cachorro"); 
            Animais.Add("Papagaio"); 
            Animais.Add("Corvo"); 

            Animais.Insert(1, "Coruja");

            Animais.Remove("Corvo");

            Animais.RemoveAt(1);

            foreach(string animal in Animais)
            {
                Console.WriteLine($"Aqui está o Animal: {animal}");
            }
        }
    }
}
