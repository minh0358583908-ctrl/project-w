using System;

class LinearEquationResolver
{
    static void Main()
    {
        Console.Write("Nhập hệ số a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập hệ số b: ");
        double b = double.Parse(Console.ReadLine());

        if (a != 0)
        {
            double x = -b / a;
            Console.WriteLine("Phương trình có nghiệm duy nhất: x = " + x);
        }
        else
        {
            if (b == 0)
            {
                Console.WriteLine("Phương trình có vô số nghiệm.");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
        }
    }
}
