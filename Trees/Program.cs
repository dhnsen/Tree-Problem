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
            Console.WriteLine("Expect 80: " + Harvest.HarvestTwoSections(new int[] { 10, 10, 0, 0, 20, 20, 20 }, 2, 3));
            Console.WriteLine("Expect 90: " + Harvest.HarvestTwoSections(new int[] { 10, 10, 20, 0, 0, 20, 20, 20 }, 3, 2));
            Console.WriteLine("Expect 100: " + Harvest.HarvestTwoSections(new int[] { 10, 10, 20, 0, 0, 30, 20, 20 }, 2, 3));
            Console.WriteLine("Expect 100: " + Harvest.HarvestTwoSections(new int[] { 10, 10, 20, 0, 0, 20, 20, 20, 0, 20, 20 }, 2, 3));

            Console.ReadLine();
        }
    }
}
