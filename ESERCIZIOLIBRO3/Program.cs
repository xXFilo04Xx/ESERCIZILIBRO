using System;
using System.Collections.Generic;

namespace ESERCIZIOLIBRO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int mass = 1000;
            int min = int.MinValue;
            int n = 30;
            List<int> list = new List<int>();
            List<int> pari = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(min, mass));
                if (list[i] % 2 == 0)
                    pari.Add(list[i]);
            }
    }
}
