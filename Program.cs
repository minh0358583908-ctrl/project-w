using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. In hình chữ nhật");
            Console.WriteLine("2. In hình tam giác vuông");
            Console.WriteLine("3. In hình tam giác cân");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintRectangle();
                    break;

                case 2:
                    PrintRightTriangleMenu();
                    break;

                case 3:
                    PrintIsoscelesTriangle();
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }
    }


    static void PrintRectangle()
    {
        int width = 6;
        int height = 3;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintRightTriangleMenu()
    {
        Console.WriteLine("\nTam giác vuông:");
        Console.WriteLine("1. Góc dưới trái");
        Console.WriteLine("2. Góc dưới phải");
        Console.WriteLine("3. Góc trên trái");
        Console.WriteLine("4. Góc trên phải");
        Console.Write("Chọn: ");

        int type = int.Parse(Console.ReadLine());
        int h = 5;

        switch (type)
        {
            case 1:
                for (int i = 1; i <= h; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("* ");
                    Console.WriteLine();
                }
                break;

            case 2: 
                for (int i = 1; i <= h; i++)
                {
                    for (int j = h; j > i; j--)
                        Console.Write("  ");
                    for (int j = 1; j <= i; j++)
                        Console.Write("* ");
                    Console.WriteLine();
                }
                break;

            case 3: 
                for (int i = h; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("* ");
                    Console.WriteLine();
                }
                break;

            case 4:
                for (int i = h; i >= 1; i--)
                {
                    for (int j = h; j > i; j--)
                        Console.Write("  ");
                    for (int j = 1; j <= i; j++)
                        Console.Write("* ");
                    Console.WriteLine();
                }
                break;

            default:
                Console.WriteLine("Sai lựa chọn!");
                break;
        }
    }
    static void PrintIsoscelesTriangle()
    {
        int h = 5;

        for (int i = 1; i <= h; i++)
        {
            for (int j = h; j > i; j--)
                Console.Write("  ");

            for (int j = 1; j <= 2 * i - 1; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
    }
}

