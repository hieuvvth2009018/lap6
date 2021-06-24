using System;
using System.Collections.Generic;

namespace Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> temperatures = new List<int>();
            temperatures.Add(1);
            temperatures.Add(200);
            temperatures.Add(15);
            temperatures.Add(50);
            temperatures.Add(120);
            temperatures.Add(10);
            int dem = 0;
            foreach (int n in temperatures)
            {
              //lọc số >=25 , còn số bé hơn 25 thì loại 
                if (n >= 25)
                {
                    dem = dem + 1;
                }
            }

            Console.WriteLine("Number of temperatures >= 25 degrees: {0}", dem);

            int dem2 = GreaterCount(temperatures, 25);

            Console.WriteLine("Number of elements of the list >= min: {0}", dem2);
        }

        public static int GreaterCount(List<int> list, double min)
        {
            int dem2 = 0;
            foreach (int n in list)
            {
                if (n >= min)
                {
                    dem2 = dem2 + 1;
                }
            }

            return dem2;
        }
    }
}