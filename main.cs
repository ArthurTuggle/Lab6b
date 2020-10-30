using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            int Height;
            int Weight;
            int BMI;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter height for person " + i + " (in inches): ");
                Height = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter weight for person " + i + " (in lb): ");
                Weight = Convert.ToInt32(Console.ReadLine());

                BMI = CalculateBMI(Height, Weight);
                BMIResults(BMI);
            }
            Console.ReadLine();
        }

        static int CalculateBMI(int Height, int Weight)
        {
            int BMI;
            BMI = (Weight * 703) / (Height * Height);
            return BMI;
        }

        static void BMIResults(int BMI)
        {
            Console.Write("Weight Status: ");
            if (BMI < 18.5)
                Console.WriteLine("Underweight");
            else if (BMI < 25.0)
                Console.WriteLine("Normal");
            else if (BMI < 30.0)
                Console.WriteLine("Overweight");
            else
                Console.WriteLine("Obese");
            Console.WriteLine();
        }
    }
}