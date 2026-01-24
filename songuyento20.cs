using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập số lượng số nguyên tố cần in ra: ");
        int numbers = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int N = 2;

        while (count < numbers)
        {
            bool isPrime = true;

            if (N < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(N); i++)
                {
                    if (N % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.Write(N + " ");
                count++;
            }

            N++;
        }
    }
}
