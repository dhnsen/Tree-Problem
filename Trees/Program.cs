using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harvest Two Sections:\n");
            Console.WriteLine("Expect 80: " + Harvest.HarvestTwoSections(new int[] { 10, 10, 0, 0, 20, 20, 20 }, 3, 2));

            Console.WriteLine("Harvest K Section:\n");
            Console.WriteLine("Expect 63: " + Harvest.HarvestK(new int[] { 10, 10, 0, 0, 22, 20, 21 }, 3));
            Console.WriteLine("Expect 60: " + Harvest.HarvestK(new int[] { 0,0,0,20,20,20,0,0 }, 3));
            Console.WriteLine("Expect 40: " + Harvest.HarvestK(new int[] { 10,10,0,0,20,20,20 }, 2));

            Console.ReadLine();
        }
    }
}
