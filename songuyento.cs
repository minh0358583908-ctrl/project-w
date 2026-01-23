using System;

class songuyento
{
    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("nhap so: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n) ? "la so nguyen to" : "khong phai so nguyen to");
    }
}
