using System;

class Program
{
    static void Main(string[] args)
    {
      
        Console.Write("Enter weight (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height (m): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height);

        Console.WriteLine("BMI = " + bmi);

        if (bmi < 18.5)
        {
            Console.WriteLine("Interpretation: Underweight");
        }
        else if (bmi < 25)
        {
            Console.WriteLine("Interpretation: Normal");
        }
        else if (bmi < 30)
        {
            Console.WriteLine("Interpretation: Overweight");
        }
        else
        {
            Console.WriteLine("Interpretation: Obese");
        }
    }
}
