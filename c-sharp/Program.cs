using System;
using System.Threading;
using System.Collections.Generic;

namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, c = 0, contS = 0, contN = 0;
            Random aleatorio = new Random();
            List<int> listaNum = new List<int>(){aleatorio.Next(0, 9), aleatorio.Next(0, 9), aleatorio.Next(0, 9), aleatorio.Next(0, 9), aleatorio.Next(0, 9)};
            foreach (var item in listaNum)
            {
                Console.WriteLine(item);
                Thread.Sleep(1000);
                //Console.Clear();
            }
            foreach (var item in listaNum)
            {
                Console.Write($"Digite {c+1}º número: ");
                num = int.Parse(Console.ReadLine());
                if(num == listaNum[c])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ACERTASTE!!!");
                    contS += 1;
                }
                else
                {
                    contN += 1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRADO!!!");
                }
                Console.ResetColor();
                c++;
            }
            Console.WriteLine($"Acertaste {contS} números");
            Console.WriteLine($"Erraste {contN} números");
        }
    }
}
