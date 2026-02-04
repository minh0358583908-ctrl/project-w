using System;

class HinhChuNhat
{
    double ChieuRong;
    double ChieuCao;

    public HinhChuNhat() { }

    public HinhChuNhat(double ChieuRong, double ChieuCao)
    {
        this.ChieuRong = ChieuRong;
        this.ChieuCao = ChieuCao;
    }

    public double TinhDienTich()
    {
        return ChieuRong * ChieuCao;
    }
    public double TinhChuVi()
    {
        return (ChieuRong + ChieuCao) * 2;

    }
    public string HienThi()
    {
        return "HinhChuNhat { Chieu Rong = " + ChieuRong + ", Chieu Cao = " + ChieuCao + " }";
    }

}
 class p
{
    static void Main(string[] args)
    {
        Console.WriteLine("nhap chieu rong: ");
        double ChieuRong = double.Parse(Console.ReadLine());
        Console.WriteLine("nhap chieu cao: ");
        double ChieuCao = double.Parse(Console.ReadLine());
        HinhChuNhat hcn = new HinhChuNhat(ChieuRong, ChieuCao);
        Console.WriteLine("thong tin hinh chu nhat: ");
        Console.WriteLine(hcn.HienThi());
        Console.WriteLine("Chu vi: " + hcn.TinhChuVi());
        Console.WriteLine("dien tich: " + hcn.TinhDienTich());  

        
      

    }
}