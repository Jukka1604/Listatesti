using System;
using System.Collections.Generic;

namespace Listatesti
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numerot = new List<int>();
            numerot.Add(1);

            for (int i = 2; i <= 10; i++)
            {
                numerot.Add(i);
            }

            numerot.Insert(0, 9);
            numerot.Insert(3, 7);

            numerot.Remove(10);  //Mikä luku poistetaan   
            numerot.RemoveAt(8); //Mikä indeksi poistetaan

            numerot[5] = 11;

            for (int i = 0; i < numerot.Count; i++)
            {

                Console.Write(numerot[i] + " ");
                
            }

            Console.WriteLine();

            numerot.Sort();
           

            foreach (var item in numerot)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            numerot.Reverse();

            foreach (var item in numerot)
            {
                Console.Write(item + " ");
            }


            Console.ReadLine();

        }
    }
}
