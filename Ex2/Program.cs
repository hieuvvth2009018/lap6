using System;
using System.Collections.Generic;

namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<double> eble = new List<double>();
            double dem = GreaterCount(eble, 0);
            Console.WriteLine("Number of elements of the list >= min: {0}", dem);
        }
        public static double GreaterCount(IEnumerable<double> eble, double min)
        {
            double dem = 0;
            foreach (double e in eble)
            {
                if (e>=min)
                {
                    dem = dem + 1;
                }
            }
            return dem;
        }
    }
}