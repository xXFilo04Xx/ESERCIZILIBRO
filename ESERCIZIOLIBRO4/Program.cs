using System;
using System.Collections.Generic;
namespace ESERCIZIOLIBRO4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<int> lista = new List<int>();
            const int TANTI = 100;
            int numero;
            for (int i = 0; i <TANTI; i++)
            {
                numero = r.Next(1, 1000);

                lista.Add(numero);

            }
            Console.WriteLine("Qual è il numero più piccolo che vuoi nella lista?");
            int max = int.Parse(Console.ReadLine());
            for (int i = 0; i < lista.Count;)
            {
                if (lista[i] < max)
                {
                    lista.RemoveAt(i);
                }
                else
                    i++;
            }
            lista.Sort();
            foreach (int a in lista)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();

        }
    }
}
