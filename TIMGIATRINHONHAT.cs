using System;

class Program
{
    
    public static int MinValue(int[] array)
    {
        int min = array[0];  
        int index = 0;        

     
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }

        return index; 
    }


    public static void Main(string[] args)
    {
        int[] arr = { 4, 12, 7, 8, 1, 6, 9 };

        int index = MinValue(arr);

        Console.WriteLine("Gia tri nho nhat trong mang la: " + arr[index]);
        Console.WriteLine("Vi tri cua no la index = " + index);
    }
}
