using System;

class Program
{
    static void Main(string[] args)
    {
        // Ma trận vuông có sẵn
        double[,] matrix =
        {
            { 1.5, 2.3, 3.1 },
            { 4.2, 5.0, 6.8 },
            { 7.4, 8.6, 9.9 }
        };

        int size = matrix.GetLength(0); // số dòng = số cột
        double sum = 0;

        // Tính tổng đường chéo chính
        for (int i = 0; i < size; i++)
        {
            sum += matrix[i, i];
        }

        Console.WriteLine("Tong cac phan tu tren duong cheo chinh: " + sum);
    }
}
