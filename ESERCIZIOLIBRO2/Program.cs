using System;
using System.Collections.Generic;

namespace ESERCIZIOLIBRO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire numeri del vettore");
            int a = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(a);
            Console.WriteLine("Inserisci numeri");
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int mass = int.MaxValue;
            int min = int.MinValue;
            List<int> crescente = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(min, mass));
                min = crescente[i];
            }
            Console.ReadLine();
        }
    }
}
