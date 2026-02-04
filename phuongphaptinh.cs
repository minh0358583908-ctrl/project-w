using System;


public class Student
{
   
    private int rollno;
    private string name;

 
    private static string college = "BBDIT";


    public Student(int r, string n)
    {
        rollno = r;
        name = n;
    }


    public static void Change()
    {
        college = "CODEGYM";
    }

   
    public void Display()
    {
        Console.WriteLine(rollno + " " + name + " " + college);
    }
}


public class phuongphaptinh
{
    public static void Main(string[] args)
    {
        
        Student.Change();

        Student s1 = new Student(111, "Minh");
        Student s2 = new Student(222, "Hung");
        Student s3 = new Student(333, "Hieu");

        s1.Display();
        s2.Display();
        s3.Display();
    }
}
