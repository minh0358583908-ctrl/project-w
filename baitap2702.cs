using System;
using System.Collections.Generic;
class PhanMem
{
    public string Ten;
    public string NhaPhatTrien;
    public double PhiHangThang;
    public PhanMem(string ten, string nha, double phi)
    {
        Ten = ten;
        NhaPhatTrien = nha;
        PhiHangThang = phi;
    }
    public virtual void InThongTin()
    {
        Console.WriteLine("Ten: " + Ten);
        Console.WriteLine("Nha phat trien: " + NhaPhatTrien);
        Console.WriteLine("Phi hang thang: " + PhiHangThang);
    }
    public double TinhChiPhi(int thang, double giamGia)
    {
        double tong = PhiHangThang * thang;
        tong = tong * (1 - giamGia / 100);
        return tong;
    }
}
class PhanMemThietKe : PhanMem
{
    public string PhienBan;
    public bool CoCloud;
    public PhanMemThietKe(string ten, string nha, double phi, string phienBan, bool coCloud)
        : base(ten, nha, phi)
    {
        PhienBan = phienBan;
        CoCloud = coCloud;
    }
    public override void InThongTin()
    {
        base.InThongTin();
        Console.WriteLine("Phien ban: " + PhienBan);
        Console.WriteLine("Cloud: " + (CoCloud ? "Co" : "Khong"));
    }
}
class CongCu : PhanMem
{
    public string LoaiMoHinh;
    public int VRAMToiThieu;
    public CongCu(string ten, string nha, double phi, string loai, int vram)
        : base(ten, nha, phi)
    {
        LoaiMoHinh = loai;
        VRAMToiThieu = vram;
    }
    public override void InThongTin()
    {
        base.InThongTin();
        Console.WriteLine("Loai mo hinh: " + LoaiMoHinh);
        Console.WriteLine("VRAM toi thieu: " + VRAMToiThieu + "GB");
    }
}
class Manager
{
    List<PhanMem> ds = new List<PhanMem>();
    public void Them(PhanMem pm)
    {
        ds.Add(pm);
    }
    public void HienThi()
    {
        foreach (var pm in ds)
        {
            Console.WriteLine("-------");
            pm.InThongTin();
        }
    }
    public void TimTheoTen(string ten)
    {
        foreach (var pm in ds)
        {
            if (pm.Ten.ToLower().Contains(ten.ToLower()))
            {
                pm.InThongTin();
            }
        }
    }
    public void LocTheoVRAM(int vram)
    {
        foreach (var pm in ds)
        {
            if (pm is CongCu cc)
            {
                if (cc.VRAMToiThieu <= vram)
                {
                    cc.InThongTin();
                }
            }
        }
    }
    public void TinhChiPhi(int thang, double giamGia)
    {
        double tongTatCa = 0;

        foreach (var pm in ds)
        {
            double tien = pm.TinhChiPhi(thang, giamGia);
            tongTatCa += tien;
        }
        Console.WriteLine("Tong chi phi: " + tongTatCa);
    }
}
class baitap2702
{
    static void Main()
    {
        Manager ql = new Manager();
        while (true)
        {
            Console.WriteLine("\n       MENU       ");
            Console.WriteLine("1. Them phan mem thiet ke");
            Console.WriteLine("2. Them cong cu");
            Console.WriteLine("3. Hien thi danh sach");
            Console.WriteLine("4. Tim theo ten");
            Console.WriteLine("5. Loc theo VRAM");
            Console.WriteLine("6. Tinh chi phi");
            Console.WriteLine("0. Thoat");
            int chon = int.Parse(Console.ReadLine());
            if (chon == 1)
            {
                Console.Write("Ten: ");
                string ten = Console.ReadLine();
                Console.Write("Nha phat trien: ");
                string nha = Console.ReadLine();
                Console.Write("Phi hang thang: ");
                double phi = double.Parse(Console.ReadLine());
                Console.Write("Phien ban: ");
                string ver = Console.ReadLine();
                Console.Write("Co cloud (true/false): ");
                bool cloud = bool.Parse(Console.ReadLine());
                ql.Them(new PhanMemThietKe(ten, nha, phi, ver, cloud));
            }
            else if (chon == 2)
            {
                Console.Write("Ten: ");
                string ten = Console.ReadLine();
                Console.Write("Nha phat trien: ");
                string nha = Console.ReadLine();
                Console.Write("Phi hang thang: ");
                double phi = double.Parse(Console.ReadLine());
                Console.Write("Loai mo hinh: ");
                string loai = Console.ReadLine();
                Console.Write("VRAM toi thieu: ");
                int vram = int.Parse(Console.ReadLine());
                ql.Them(new CongCu(ten, nha, phi, loai, vram));
            }
            else if (chon == 3)
            {
                ql.HienThi();
            }
            else if (chon == 4)
            {
                Console.Write("Nhap ten can tim: ");
                string ten = Console.ReadLine();
                ql.TimTheoTen(ten);
            }
            else if (chon == 5)
            {
                Console.Write("Nhap VRAM may: ");
                int vram = int.Parse(Console.ReadLine());
                ql.LocTheoVRAM(vram);
            }
            else if (chon == 6)
            {
                Console.Write("Nhap so thang: ");
                int thang = int.Parse(Console.ReadLine());
                Console.Write("Nhap giam gia (%): ");
                double giam = double.Parse(Console.ReadLine());
                ql.TinhChiPhi(thang, giam);
            }
            else if (chon == 0)
            {
                break;
            }
        }
    }
}