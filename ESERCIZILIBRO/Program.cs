
using System;
using System.Collections.Generic;

namespace ESERCIZILIBRO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire numeri del vettore");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(n);
            List<int> duplicati = new List<int>();
            for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Inserisci un numero");
                    int n1 = int.Parse(Console.ReadLine());
                    if (list.Contains(n1))
                        duplicati.Add(n1);
                    list.Add(n1);
                }
                for (int i = 0; i < duplicati.Count; i++)
                {
                    Console.WriteLine($"Il numero {duplicati[i]} è doppione.");
                }
                Console.ReadLine();
        }
    }
}
