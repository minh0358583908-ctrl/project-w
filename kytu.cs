using System;
class p
{
    static int DemKyTu(string str, char KyTU)
    {
        int dem = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == KyTU)
            {
                dem ++;
            }
        }
        return dem;


    }
     static void Main(string[] args)
    {
        string chuoi = "lap trinh C#";
        Console.Write("nhap ky tu can dem: ");
        char KyTu = Console.ReadLine()[0];
        int KetQua = DemKyTu(chuoi, KyTu);
        Console.WriteLine($"so lan xuat hien cua '{KyTu}' trong chuoi la: {KetQua}");
    }

}