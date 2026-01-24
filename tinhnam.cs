using System;

class tinhnam
{
    static void Main(string[] args)
    {
        int year;
        bool isLeapYear = false;

        Console.Write("Nhập năm cần kiểm tra: ");
        year = Convert.ToInt32(Console.ReadLine());

        bool isDivisibleBy4 = year % 4 == 0;

        if (isDivisibleBy4)
        {
            bool isDivisibleBy100 = year % 100 == 0;

            if (isDivisibleBy100)
            {
                bool isDivisibleBy400 = year % 400 == 0;

                if (isDivisibleBy400)
                {
                    isLeapYear = true;
                }
            }
            else
            {
                isLeapYear = true;
            }
        }

        if (isLeapYear)
        {
            Console.WriteLine("{0} là năm nhuận", year);
        }
        else
        {
            Console.WriteLine("{0} không phải là năm nhuận", year);
        }
    }
}
