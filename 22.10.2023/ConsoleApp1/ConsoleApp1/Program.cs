using ConsoleApp1;
using System;
using System.Text.RegularExpressions;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            Console.Write("Input a positive number (integer): ");
//            int number = Convert.ToInt32(Console.ReadLine());

//            int factorial = CalculateFactorial(number);

//            Console.WriteLine("Factorial: " + factorial);
//        }
//        catch (OverflowException)
//        {
//            Console.WriteLine("Error: Factorial exceeds the maximum value of Int32.");
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Error: Invalid input. Please enter a valid number.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("An error occurred: " + ex.Message);
//        }
//    }

//    static int CalculateFactorial(int number)
//    {
//        if (number < 0)
//        {
//            throw new ArgumentException("Number must be non-negative.");
//        }

//        int factorial = 1;
//        for (int i = 1; i <= number; i++)
//        {
//            checked
//            {
//                factorial *= i;
//            }
//        }

//        return factorial;
//    }
//}

class Program
{
    static void Main()
    {
        string email1 = "oruc@gmail.com";
        string email2 = "orucgmailcom";

        bool CheckEmail1 = email1.CheckEmail();
        bool CheckEmail2 = email2.CheckEmail();

        Console.WriteLine($"Is '{email1}' a valid email? {CheckEmail1}");
        Console.WriteLine($"Is '{email2}' a valid email? {CheckEmail2}");
    }
}