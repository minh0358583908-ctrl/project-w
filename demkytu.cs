using System;

class Program
{
   
    public static int CountCharacter(string str, char ch)
    {
        int count = 0; 

       
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ch)
            {
                count++;
            }
        }

        return count;
    }


    static void Main(string[] args)
    {
        string str = "lap trinh csharp";

        Console.Write("Nhap ky tu can dem: ");
        char ch = Console.ReadLine()[0];

        int result = CountCharacter(str, ch);

        Console.WriteLine("So lan xuat hien cua '" + ch + "' la: " + result);
    }
}
