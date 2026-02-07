using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            double MyHeight = 5.6;   //feet
            double MyWeight = 81.10; //Kg

            double roundedWeight = Math.Round(MyWeight);      
            double heightSquared = Math.Pow(MyHeight, 2);     
            double heightSquareRoot = Math.Sqrt(MyHeight);    
            double higherValue = Math.Max(MyHeight, MyWeight); 
            double lowerValue = Math.Min(MyHeight, MyWeight);   

            Console.WriteLine("Height: " + MyHeight);
            Console.WriteLine("Weight: " + MyWeight);
            Console.WriteLine("Rounded weight: " + roundedWeight);
            Console.WriteLine("Height squared: " + heightSquared);
            Console.WriteLine("Square root of height: " + heightSquareRoot);
            Console.WriteLine("Higher value: " + higherValue);
            Console.WriteLine("Lower value: " + lowerValue);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
