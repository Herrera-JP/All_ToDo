using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double g1, g2, g3, g4, g5;
            double average;
            double rounded;

            Console.WriteLine("Enter 5 grades separated by new line:");

            g1 = Convert.ToDouble(Console.ReadLine());
            g2 = Convert.ToDouble(Console.ReadLine());
            g3 = Convert.ToDouble(Console.ReadLine());
            g4 = Convert.ToDouble(Console.ReadLine());
            g5 = Convert.ToDouble(Console.ReadLine());

            average = (g1 + g2 + g3 + g4 + g5) / 5;
            rounded = Math.Round(average);

            Console.WriteLine("The average is " + average + " and round off to " + rounded);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
