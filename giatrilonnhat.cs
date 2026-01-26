using System;
class giatrilonnhat
{
    static void Main()
    {
        int size;
        int[] array;
        do
        {
            Console.WriteLine("nhap kich thuoc mang:");
            size = Int32.Parse(Console.ReadLine());
            if (size > 20)
                Console.WriteLine("kich thuoc khong vuot qua 20");
        }
        while (size > 20);

        array = new int[size];
        int i = 0;
        while (i < array.Length)
        {
            Console.WriteLine("nhap phan tu thu" + (i + 1) + ":");
            array[i] = Int32.Parse(Console.ReadLine()) ;
            i++;

        }
        Console.WriteLine("danh sach tai san:");
        for (int n = 0; n < array.Length; n++)
        {
            Console.WriteLine(array[n] + "\t");

        }
        int max = array[0];
        int index = 1;
        for (int n = 0; n < array.Length; ++n)
        {
            if (array[n] > max)
            {
                max = array[n];
                index = n + 1;
            }
            Console.WriteLine("gia tri lon nhat trong danh sach la " + max + ",tai vi tri" +  index);
                }

    }
}