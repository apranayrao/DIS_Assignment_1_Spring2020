using System;

namespace DIS_Assignment_1_Spring2020
{
    class Program
    {
        private static void PrintPattern(double num)
        {
                double i = num; 
                if (num > 0)
                {
                    while (i > 0)
                    {
                        Console.Write(i);
                        Console.Write("");
                        i--;
                    }
                Console.WriteLine("\n");
                num--;
                    PrintPattern(num);
                }
            
        }
        static void Main(string[] args)
        {
         
            //Enter the value of num
            double num;
            Console.WriteLine("Enter the Number of lines for pattern:");
            num = Convert.ToDouble(Console.ReadLine());
            PrintPattern(num);

        }
    }
}
