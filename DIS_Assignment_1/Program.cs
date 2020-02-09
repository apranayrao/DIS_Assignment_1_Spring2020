using System;
using System.Linq;

namespace DIS_Assignment_1_Spring2020
{
    class Program
    {
        private static void PrintPattern(double num)
        {
            try
            {
                double i = num;
                if (num > 0)
                {
                    while (i > 0)
                    {
                        Console.Write(i); // Prints row
                        Console.Write("");
                        i--;
                    }
                    Console.WriteLine("\n");
                    num--;
                    PrintPattern(num); //Prints next line with one less number, function called again with num-1
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }

        }

        private static void PrintSeries(double num2)
        {
            try
            {
                double j, sum = 0;
                for (j = 1; j <= num2; j++) //Prints sum of n no upto specified number
                {
                    sum += j;
                    Console.Write(sum);
                    Console.Write(" ");
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }


        }

        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                int ctr = 1;
                for (int i = 0; i < n3 / k; i++)
                {


                    for (int j = 0; j < k; j++)
                    {
                        if (ctr % 3 == 0) //If divisible by 3, then we check for cases of div by 5, 7 & all 3,5&7
                        {
                            if (ctr % 5 == 0 & ctr % 7 == 0)
                            {
                                Console.Write("USF" + " ");
                            }
                            else if (ctr % 5 == 0)
                            {
                                Console.Write("US" + " ");
                            }
                            else if (ctr % 7 == 0)
                            {
                                Console.Write("UF" + " ");
                            }

                            else
                            {
                                Console.Write("U" + " ");
                            }
                            ctr++;
                        }
                        else if (ctr % 5 == 0) //Divisibility by 5
                        {
                            if (ctr % 7 == 0) //Divisiblity by 5 & 7
                            {
                                Console.Write("SF" + " ");
                            }
                            else
                            {
                                Console.Write("S" + " ");
                            }
                            ctr++;
                        }
                        else if (ctr % 7 == 0)
                        {
                            Console.Write("F" + " ");
                            ctr++;
                        }
                        else //Not div by 3,5,7
                        {
                            Console.Write(ctr + " ");
                            ctr++;
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }

        }
        public static string UsfTime(string s)
        {
            try
            {
                if (s.Contains("PM")) //Checks if time has PM
                {
                    string hoursInString = s.Split(':')[0]; //Extracts Hour part
                    int hours = Convert.ToInt32(hoursInString);
                    int HoursInminutes = (12 + (hours % 60)) * 60; //Converts hours to minutes
                    string minutesInString = s.Split(':')[1];
                    int minutes = Convert.ToInt32(minutesInString);
                    int totalMinutes = HoursInminutes + minutes; //Total Earth minutes
                    string secondsInString = s.Substring(6, 2); //Extracts seconds part
                    int seconds = Convert.ToInt32(secondsInString);
                    int totalseconds = totalMinutes * 60 + seconds; //Total Earth Seconds
                    double usfhours = totalseconds / 2700.0; //USF hours with decimals
                    long hour_usf = (long)usfhours;
                    double min_usf = (usfhours - hour_usf) * 60.0; //USF minutes
                    long minute_usf = (long)min_usf;
                    double sec_usf = (min_usf - minute_usf) * 45.0;
                    long second_usf = (long)sec_usf;
                    string usftime = (hour_usf + ":" + minute_usf + ":" + second_usf); //USF time after extracting minutes & seconds
                    return usftime;
                }
                else //Similar to above but for non PM condition
                {
                    string hoursInString = s.Split(':')[0];
                    int hours = Convert.ToInt32(hoursInString);
                    int HoursInminutes = (hours % 60) * 60;
                    string minutesInString = s.Split(':')[1];
                    int minutes = Convert.ToInt32(minutesInString);
                    int totalMinutes = HoursInminutes + minutes;
                    string secondsInString = s.Split(':')[2];
                    int seconds = Convert.ToInt32(secondsInString);
                    int totalseconds = totalMinutes * 60 + seconds;
                    double usfhours = totalseconds / 2700.0;
                    long hour_usf = (long)usfhours;
                    double min_usf = (usfhours - hour_usf) * 60.0;
                    long minute_usf = (long)min_usf;
                    double sec_usf = (min_usf - minute_usf) * 45.0;
                    long second_usf = (long)sec_usf;
                    string usftime = (hour_usf + ":" + minute_usf + ":" + second_usf);
                    return usftime;
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;

        }

        public static void PalindromePairs(string[] words)
        {
            try
            {
                Console.Write("The palindromes are: ");
                for (int i = 0; i < words.Length; i++) //Outer loop for picking first string to compare with others
                {


                    int j = words.Length - 1; //Index for no of strings in list

                init:
                    string pal = String.Concat(words[i], words[j]); //Concatenates all possible string combinatations
                    int length = pal.Length;
                    for (int k = 0; k < length / 2; k++) //Checking Palindrome
                    {
                        if (pal[k] != pal[length - k - 1] || i == j) //If not equal, then not palindrome & checks other cominations from above
                        {
                            j--;
                            goto init;
                        }

                    }


                    Console.Write("[" + i + "," + j + "]");
                }

            }
            catch
            {
                Console.Write("");
            }

        }
        public static void Stones(int n4)
        {
            if(n4%4 == 0) //If no of stones are div by 4, then player one always looses
            {
                Console.WriteLine("Output: False");
            }
            else
            {
                Console.WriteLine("Output:");
                if (n4 < 4)
                {
                    while (n4 > 0) //For the case when no of stones is less than 4
                    {
                        Console.Write("[" + n4+"]  ");
                        n4--;
                        }
                }
                else
                {
                    int m = n4 % 4;
                    for(int j=1; j<=3;j++) //We take reminder with 4 & make cases
                    {
                        int k = n4 - (m+j);
                        Console.Write("[" + m + ", "+j+ ", "+ k );
                        Console.Write("]");
                    }
                    
                }
            }
        }
        static void Main(string[] args)
        {
            //Enter the value of num
            double num, num2;
            Console.WriteLine("Enter the Number of Lines for pattern:");
            num = Convert.ToDouble(Console.ReadLine());
            PrintPattern(num);
            Console.WriteLine("Enter the number of terms of the series:");
            num2 = Convert.ToDouble(Console.ReadLine());
            PrintSeries(num2);
            Console.WriteLine("\n Enter Time on Earth:");
            string s = Console.ReadLine();
            string usf_time = UsfTime(s);
            Console.WriteLine(usf_time);
            Console.WriteLine("\n USF Numbers (Enter n): \n");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n USF Numbers (Enter k): \n");
            int k = Convert.ToInt32(Console.ReadLine());
            UsfNumbers(n3, k);
            Console.WriteLine("\n");
            string[] words = { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);
            int n4;
            Console.WriteLine("\n");
            Console.Write("Input:");
            n4 = Convert.ToInt32(Console.ReadLine());
            Stones(n4);
        }
    }
}
   
