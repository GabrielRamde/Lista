using System;
using System.Collections.Generic;
namespace lista1
{
    class Program
    {
        static void Main()
        {
            List<double> tallista = new List<double>();
                tallista.Add(1.5);
                tallista.Add(2.5);
                tallista.Add(3.5);
                tallista.Add(4.5);
                tallista.RemoveAt(3);
            for (int i = 0; i < tallista.Count; i++)
                Console.WriteLine(tallista[i]);

                
        }
    }
}
