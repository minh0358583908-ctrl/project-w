using System;
namespace baitapvenha
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int x = a++ + ++a + a++;
            Console.WriteLine("Gia tri cua x=" + x);
            Console.WriteLine("Gia tri cua a=" + a);
            Console.ReadLine();
        }
    }
}   
