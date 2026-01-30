using System;

class MineSweeper
{
    static void Main(string[] args)
    {
        // Bản đồ gốc
        string[,] map =
        {
            { "*", ".", ".", "." },
            { ".", ".", ".", "." },
            { ".", "*", ".", "." },
            { ".", ".", ".", "." }
        };

        int MAP_HEIGHT = map.GetLength(0);
        int MAP_WIDTH = map.GetLength(1);

        // Bản đồ báo cáo
        string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH];

        // Duyệt từng ô
        for (int y = 0; y < MAP_HEIGHT; y++)
        {
            for (int x = 0; x < MAP_WIDTH; x++)
            {
                string currentCell = map[y, x];

                // Nếu là mìn
                if (currentCell.Equals("*"))
                {
                    mapReport[y, x] = "*";
                }
                else
                {
                    int minesAround = 0;

                    // Danh sách 8 láng giềng
                    int[,] NEIGHBOURS_ORDINATE =
                    {
                        { y - 1, x - 1 }, { y - 1, x }, { y - 1, x + 1 },
                        { y,     x - 1 },                 { y,     x + 1 },
                        { y + 1, x - 1 }, { y + 1, x }, { y + 1, x + 1 }
                    };

                    // Duyệt các láng giềng
                    for (int i = 0; i < NEIGHBOURS_ORDINATE.GetLength(0); i++)
                    {
                        int ny = NEIGHBOURS_ORDINATE[i, 0];
                        int nx = NEIGHBOURS_ORDINATE[i, 1];

                        // Kiểm tra ra ngoài bản đồ
                        bool isOutOfMap =
                            ny < 0 || ny >= MAP_HEIGHT ||
                            nx < 0 || nx >= MAP_WIDTH;

                        if (isOutOfMap) continue;

                        // Kiểm tra có mìn không
                        if (map[ny, nx].Equals("*"))
                        {
                            minesAround++;
                        }
                    }

                    mapReport[y, x] = minesAround.ToString();
                }
            }
        }

        // In kết quả
        Console.WriteLine("Ban do MineSweeper:");
        for (int y = 0; y < MAP_HEIGHT; y++)
        {
            for (int x = 0; x < MAP_WIDTH; x++)
            {
                Console.Write(mapReport[y, x]);
            }
            Console.WriteLine();
        }
    }
}
