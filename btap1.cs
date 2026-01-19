using System;

class SoNgayTrongThang
{
    static bool LaNamNhuan(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập tháng: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Nhập năm: ");
        int year = int.Parse(Console.ReadLine());

        int days;

        switch (month)
        {
            // Nhóm tháng 31 ngày
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                days = 31;
                break;

            // Nhóm tháng 30 ngày
            case 4:
            case 6:
            case 9:
            case 11:
                days = 30;
                break;

            // Tháng 2 xử lý riêng
            case 2:
                days = LaNamNhuan(year) ? 29 : 28;
                break;

            default:
                Console.WriteLine("Tháng không hợp lệ!");
                return;
        }

        Console.WriteLine($"Tháng {month} năm {year} có {days} ngày");
    }
}

