using System;

class Program
{
    // Chuyển từ độ C sang độ F
    public static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (9.0 / 5) * celsius + 32;
        return fahrenheit;
    }

    // Chuyển từ độ F sang độ C
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (5.0 / 9) * (fahrenheit - 32);
        return celsius;
    }

    // Hàm Main
    public static void Main(string[] args)
    {
        int choice;
        double celsius, fahrenheit;

        do
        {
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("1. Chuyen doi Fahrenheit sang Celsius");
            Console.WriteLine("2. Chuyen doi Celsius sang Fahrenheit");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");

            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhap Fahrenheit: ");
                    fahrenheit = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Celsius = " + FahrenheitToCelsius(fahrenheit));
                    break;

                case 2:
                    Console.Write("Nhap Celsius: ");
                    celsius = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Fahrenheit = " + CelsiusToFahrenheit(celsius));
                    break;

                case 0:
                    Console.WriteLine("Thoat chuong trinh!");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

        } while (choice != 0);
    }
}
