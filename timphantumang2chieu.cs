using System;

class Program
{
    static void Main(string[] args)
    {
        // Ma trận có sẵn
        double[,] matrix =
        {
            { 1.2, 3.5, 2.1 },
            { 9.8, 4.6, 7.3 },
            { 0.5, 6.4, 8.9 }
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Giả sử phần tử đầu tiên là lớn nhất
        double maxValue = matrix[0, 0];
        int maxRow = 0;
        int maxCol = 0;

        // Duyệt ma trận
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > maxValue)
                {
                    maxValue = matrix[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        // In kết quả
        Console.WriteLine("Gia tri lon nhat: " + maxValue);
        Console.WriteLine("Toa do: (" + maxRow + ", " + maxCol + ")");
    }
}
