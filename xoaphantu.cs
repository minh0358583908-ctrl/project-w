using System;

class Program
{
    // Phương thức xoá phần tử X khỏi mảng
    public static void DeleteElement(int[] arr, int x)
    {
        int index_del = -1;

        // Bước 3: Tìm vị trí phần tử cần xoá
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                index_del = i;
                break;
            }
        }

        // Nếu không tìm thấy
        if (index_del == -1)
        {
            Console.WriteLine("Phan tu khong ton tai trong mang");
            return;
        }

        // Bước 4: Dịch trái các phần tử
        for (int i = index_del; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }

        // Gán phần tử cuối = 0 (cho đẹp)
        arr[arr.Length - 1] = 0;
    }

    // Main
    public static void Main(string[] args)
    {
        int[] arr = { 10, 4, 6, 7, 8, 6, 0, 0, 0, 0 };

        Console.Write("Nhap phan tu can xoa: ");
        int x = Int32.Parse(Console.ReadLine());

        DeleteElement(arr, x);

        Console.WriteLine("Mang sau khi xoa:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
