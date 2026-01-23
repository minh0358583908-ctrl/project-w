using System;

class LoanInterestCalculator
{
    static void Main()
    {
        Console.Write("Nhập số tiền cho vay (VNĐ): ");
        double soTienGui = double.Parse(Console.ReadLine());

        Console.Write("Nhập lãi suất (%/năm): ");
        double laiSuatNam = double.Parse(Console.ReadLine());

        Console.Write("Nhập số tháng cho vay: ");
        int soThang = int.Parse(Console.ReadLine());
        double tienLai = soTienGui * (laiSuatNam / 100) / 12 * soThang;
        double tongTien = soTienGui + tienLai;
        Console.WriteLine("\n--- KẾT QUẢ ---");
        Console.WriteLine("Tiền lãi: " + tienLai + " VNĐ");
        Console.WriteLine("Tổng tiền nhận được: " + tongTien + " VNĐ");
    }
}
