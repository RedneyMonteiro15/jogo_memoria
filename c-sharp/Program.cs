using System;
using System.Threading;
using System.Collections.Generic;

namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i = 0, contS = 0, contN = 0, total = 0;
            while (true)
            {
                cabecalho("Tentando Sua Memoria");
                int c = 0;
                Random aleatorio = new Random();
                List<int> listaNum = new List<int>();
                Console.WriteLine("Lista dos número sorteado:");
                for(int d = 0; d < i+1; d++)
                {
                    listaNum.Add(aleatorio.Next(0, 9));
                }
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var item in listaNum)
                {
                    Console.Write($" {item}");
                    Thread.Sleep(1000);
                }
                Console.WriteLine(" ");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
                cabecalho("Tentando Sua Memoria");
                foreach (var item in listaNum)
                {
                    Console.Write($"Qual foi o {c+1}º número? ");
                    num = int.Parse(Console.ReadLine());
                    if(num == listaNum[c])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ACERTASTE!!!");
                        Console.ResetColor();
                        contS += 1;
                    }
                    else
                    {
                        contN += 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("GAME OVER!!!");
                        Console.ResetColor();
                        break;
                    }
                    c++;
                }
                if(contN == 1)
                {
                    break;
                }
                total++;
                i++;
                Console.Clear();
            }
            if(total == 0)
            {
                Console.WriteLine("Não Acertaste nenhuma vez!!!");
            }
            else if(total == 1)
            {
                Console.WriteLine($"Ganhaste apenas {total} partida!!!");
                if(contS == 1)
                {
                    Console.WriteLine($"Acertaste {contS} número!!!");
                }
                else
                {
                    Console.WriteLine($"Acertaste {contS} números!!!");
                }
            }
            else
            {
                Console.WriteLine($"Ganhaste {total} partidas!!!");
                Console.WriteLine($"Acertaste {contS} números");
            }
        }
        static void linha()
        {
            Console.WriteLine("------------------------------");
        }
        static void cabecalho(string msg)
        {
            linha();
            center(msg, 30);
            linha();
        }
        static void center(string teste, int num){
            int total, esquerda, direita;
            string test = "";
            total = num - teste.Length;
            direita = (total / 2) + teste.Length;
            esquerda = num - direita;
            Console.WriteLine("{0}{1}", teste.PadLeft(direita, ' '), test.PadRight(esquerda-1, ' '));
        }
    }
}
