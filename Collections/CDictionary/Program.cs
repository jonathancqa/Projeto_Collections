﻿using System;
using System.Collections.Generic;

namespace CDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Dicionario de Mentalidades e Habilidades da GEN =====\n");

            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("Mentalidade de Crescimento", new string("Ter uma mentalidade de crescimento é acreditar que suas competências mais básicas podem ser desenvolvidas através de dedicação e trabalho árduo. O cérebro e o talento são apenas o ponto de partida."));
            dic.Add("Mentalidade de Persistência", new string("Ser persistente significa que você continuará tentando vez após vez. Em cada tentativa, você estará mais próximo do sucesso."));
            dic.Add("Mentalidade de Responsabilidade pessoal", new string("Responsabilidade pessoal significa assumir a responsabilidade por suas próprias ações, trabalhando arduamente, mantendo seus compromissos e não dando desculpas."));
            dic.Add("Mentalidade de Orientação ao Futuro", new string("Ter orientação ao futuro significa estabelecer metas para o seu futuro, compreender como as ações de hoje impactam nessas metas e verificar seu progresso com frequência."));
            

            Dictionary<string, string> dicH = new Dictionary<string, string>();

            dicH.Add("Habilidade de Comunicação", new string("Uma boa comunicação significa capacidade de expressar ideias de forma clara e concisa, com linguagem apropriada ao público, assim como ouvir com atençãom, manter contato visual com seus interlocutores e tomar notas ao receber novas informações."));
            dicH.Add("Habilidade de Proatividade", new string("Proatividade significa assumir a liderança em seu emprego sem nenhum impulso de seu gerente, antecipando situações e tomando as ações preventivas que forem necessárias."));
            dicH.Add("Habilidade de Orientação ao detalhe", new string("Orientação ao detalhe consiste em estar constantemente atento aos detalhes ao executar tarefas, a fim de serem completadas com precisão e cuidado."));
            dicH.Add("Habilidade de Trabalho em equipe", new string("Trabalho em equipe Consiste em um trupo de pessoas, ou apenas duas pessoas, trabalhando em conjunto visando um objetivo em comum."));
            
            Console.WriteLine("\n===== Mentalidades =====\n");

            foreach(KeyValuePair<string, string> kvp in dic)
            {
                Console.WriteLine($"\n{kvp.Key}" +
                                  $"\nDefinição: " + kvp.Value);
            }
            
            Console.WriteLine("\n===== Habilidades =====\n");

            foreach (KeyValuePair<string, string> kvp in dicH)
            {
               Console.WriteLine($"\n{kvp.Key}" +
                                 $"\nDefinição: {kvp.Value}");
            }


        }

        public class mentalidades
        {
            string Definicao { get; set; }

            public mentalidades(string definicao)
            {
                Definicao = definicao;
            }
        }

        public class habilidades
        {
            string Definicao { set; get; }

            public habilidades(string definicao)
            {
                Definicao = definicao;
            }
        }
    }
}
