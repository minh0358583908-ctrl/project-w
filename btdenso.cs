using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Các số nguyên tố nhỏ hơn 100 là:");

        for (int i = 2; i < 100; i++)
        {
            bool isPrime = true;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write(i + " ");
            }
        }
    }
}
