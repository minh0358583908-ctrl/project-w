using System;
class timgiatricuamang
{
    static void Main()
    {
        string[] students = {
          "hoan",  "minh" , "hiep" , "hung", "hieu",
          "hoa", "thao" , "tung" , "duong", "son"
            };
        Console.WriteLine("nhap ten sinh vien");
        string input_name = Console.ReadLine();
        bool isExist = false;
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].EndsWith(input_name))
            {
                Console.WriteLine("vi tri sinh vien co ten" + input_name + "la: " + (i + 1));
                isExist = true;
                break;
            }
            if (!isExist)
            {
                Console.WriteLine("khong tim thay sv" + input_name + "trong danh sach");
            }
        }
    }
}