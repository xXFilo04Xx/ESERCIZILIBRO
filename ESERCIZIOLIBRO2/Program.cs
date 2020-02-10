using System;
using System.Collections.Generic;

namespace ESERCIZIOLIBRO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci numeri");
            int n = int.Parse(Console.ReadLine());
            int mass = int.MaxValue;
            int min = int.MinValue;
            Random r = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(min, mass));
                min = list[i];
            }
        }
    }
}
