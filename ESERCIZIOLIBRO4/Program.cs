using System;
using System.Collections.Generic;
namespace ESERCIZIOLIBRO4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci numeri");
            int n = int.Parse(Console.ReadLine());
            int mass = 1000;
            int min = int.MinValue;
            Console.WriteLine("Qual è il numero più piccolo che vuoi nella lista?");
            int m = int.Parse(Console.ReadLine());
            Random r = new Random();
            List<int> lista = new List<int>();
            int numero;
            for (int i = 0; i < n; i++)
            {
                numero = r.Next(min, mass);
                if (numero >= m)
                    lista.Add(numero);
            }
        }
    }
}
