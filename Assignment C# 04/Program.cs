using System;

namespace Assignment_C__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 13
            //Console.WriteLine("Enter a string");
            //string[] str = new string[5];
            //for (int i = 0; i < str.Length; i++)
            //{
            //    str[i] = Console.ReadLine();

            //}
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}

            #endregion

            #region Q 14
            //Console.WriteLine("Enter an integer");
            //int[] num = new int[5];
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());

            //}
            //for (int i = num.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(num[i]);
            //}
            #endregion

            #region Q 15
            //Console.WriteLine("enter the starting number of range");
            //int s = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the ending number of range");
            //int e = int.Parse(Console.ReadLine());
            //for (int i = s; i < e; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //static bool IsPrime(int num)
            //{
            //    if (num < 2) return false;

            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0) return false;
            //    }
            //    return true;
            //}
            #endregion

            #region Q 16
            //Console.WriteLine("Enter a decimal number:");
            //int decimalNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Binary representation:");
            //ConvertToBinary(decimalNumber);


            //static void ConvertToBinary(int number)
            //{
            //    if (number == 0)
            //    {
            //        Console.WriteLine(0);
            //        return;
            //    }

            //    string binary = string.Empty;

            //    while (number > 0)
            //    {
            //        int remainder = number % 2;
            //        binary = remainder + binary;
            //        number /= 2;
            //    }

            //    Console.WriteLine(binary);
            //}

            #endregion

            #region Q 17
            //Console.WriteLine("Enter the coordinates for the first point (x1, y1):");
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates for the second point (x2, y2):");
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates for the third point (x3, y3):");
            //double x3 = double.Parse(Console.ReadLine());
            //double y3 = double.Parse(Console.ReadLine());


            //if (ArePointsCollinear(x1, y1, x2, y2, x3, y3))
            //{
            //    Console.WriteLine("The points lie on the same straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on the same straight line.");
            //}



            //static bool ArePointsCollinear(double x1, double y1, double x2, double y2, double x3, double y3)
            //{

            // double area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);

            // return area == 0;
            //}
            #endregion

            #region Q 18
            //Console.WriteLine("enter the task hours taken ");
            //double hours = double.Parse(Console.ReadLine());
            //if (hours >= 2 && hours <= 3)
            //{
            //    Console.WriteLine("highly efficient");
            //}
            //else if (hours >= 3 && hours <= 4)
            //{
            //    Console.WriteLine("instructed to increase their speed");
            //}
            //else if (hours >= 4 && hours <= 5)
            //{
            //    Console.WriteLine("provided with training to enhance their speed");
            //}
            //else if (hours > 5)
            //{
            //    Console.WriteLine("required to leave the company");
            //}
            //else
            //{
            //    Console.WriteLine("enter a correct hour");
            //}

            #endregion
        }
    }
}


