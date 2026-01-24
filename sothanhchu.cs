using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập số cần đọc: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0 || number > 999)
        {
            Console.WriteLine("out of ability");
        }
        else if (number < 10)
        {
            Console.WriteLine(ReadOneDigit(number));
        }
        else if (number < 20)
        {
            Console.WriteLine(ReadUnderTwenty(number));
        }
        else if (number < 100)
        {
            Console.WriteLine(ReadTwoDigits(number));
        }
        else
        {
            Console.WriteLine(ReadThreeDigits(number));
        }
    }

    // Đọc số 1 chữ số
    static string ReadOneDigit(int number)
    {
        switch (number)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "";
        }
    }

    // Đọc số từ 10 đến 19
    static string ReadUnderTwenty(int number)
    {
        switch (number)
        {
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "thirteen";
            case 14: return "fourteen";
            case 15: return "fifteen";
            case 16: return "sixteen";
            case 17: return "seventeen";
            case 18: return "eighteen";
            case 19: return "nineteen";
            default: return "";
        }
    }

    // Đọc số từ 20 đến 99
    static string ReadTwoDigits(int number)
    {
        int tens = number / 10;
        int ones = number % 10;
        string result = "";

        switch (tens)
        {
            case 2: result = "twenty"; break;
            case 3: result = "thirty"; break;
            case 4: result = "forty"; break;
            case 5: result = "fifty"; break;
            case 6: result = "sixty"; break;
            case 7: result = "seventy"; break;
            case 8: result = "eighty"; break;
            case 9: result = "ninety"; break;
        }

        if (ones != 0)
        {
            result += " " + ReadOneDigit(ones);
        }

        return result;
    }

    // Đọc số từ 100 đến 999
    static string ReadThreeDigits(int number)
    {
        int hundreds = number / 100;
        int remainder = number % 100;

        string result = ReadOneDigit(hundreds) + " hundred";

        if (remainder != 0)
        {
            result += " and ";

            if (remainder < 10)
                result += ReadOneDigit(remainder);
            else if (remainder < 20)
                result += ReadUnderTwenty(remainder);
            else
                result += ReadTwoDigits(remainder);
        }

        return result;
    }
}
