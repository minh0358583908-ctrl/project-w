using System;

class Program
{
    static void Main(string[] args)
    {
        double rate = 23000;
        Console.Write("Enter USD amount: ");
        double usd = Convert.ToDouble(Console.ReadLine());
        double vnd = usd * rate;
        Console.WriteLine("VND amount: " + vnd);
    }
}

