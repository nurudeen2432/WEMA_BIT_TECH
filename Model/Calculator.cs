using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_TECH_NURUDEEN_DUROWADE.Model.Calculator;

public class Calculator
{
    public void Calculating()
    {

        static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        int counter = 0;    
        while (true && counter <= 2)
        {

            try

            {

                Console.WriteLine("Triangle Area Calculator");

                // Input base and height from the user
                Console.Write("Enter the base of the triangle: ");
                double baseLength = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the height of the triangle: ");
                double height = Convert.ToDouble(Console.ReadLine());

                // Calculate the area of the triangle
                double area = CalculateTriangleArea(baseLength, height);


                // Display the result
                Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {area}");

                Console.ReadLine(); // Pause console to view the result

            }

            catch

            {
                Console.WriteLine(" \t Invalid input, Kindly enter a number ");
                counter++;
                Console.WriteLine("\n Try again");
            }
        }

    }
}
