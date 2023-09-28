using System;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_2_CSharp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int num1, num2;

            /*Console.Write("Enter any numbers 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter any numbers 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();*/


            /*int count = countNum(num1);
            Console.WriteLine($"The numbers {num1} contains number of digits : {count} ");*/


            /*int fact = getFactorial(num1);
            Console.WriteLine($"The factorial of the given number is: {fact}");*/


            /*Console.WriteLine("Input the range to print starting from 1 : 20");
            num1 = 1; num2 = 20;
            Console.WriteLine();

            Console.WriteLine("All even numbers from 1 to 20 are : ");
            getEvenRange(num1, num2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("All Odd numbers from 1 to 20 are : ");
            getOddRange(num1, num2);
            Console.WriteLine();*/


            //getRightAngleTri(num1); //ONLINE HELP

            //getPyramidTri(num1); //ONLINE HELP

            //getSum(num1); //Not DONE

            /*
            Console.WriteLine($"Prime number form {num1} to {num2} are: ");
            getPrimeNum(num1, num2);*/  // NOT DONE


            /*Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            getChar(name);*/


            /*Console.Write("Write temprature in Celsius: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            getTemp(num1);*/


            //getGrade();


            //checkWeather();


            /*Console.Write("write a Year: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if(isLeapYear(num1))
            {
                Console.WriteLine($"A {num1} is a Leap Year");
            }
            else
            {
                Console.WriteLine($"A {num1} is a NOT Leap Year");
            }*/


        }

        /* Write a program in C# Sharp to count the number of digits in a number using recursion.
     Test Data :
     Input any number : 12345
     Expected Output :
     The number 12345 contains number of digits : 5 */

        static int countNum(int a)
        {
            if (a <= 10)
            {
                return 1;
            }
            else
            {
                return 1 + countNum(a / 10);

            }

        }
        /*Write a program in C# Sharp to find the factorial of a given number using recursion.
Test Data :
Input any positive number : 5
Expected Output :
The factorial of 5 is : 120*/

        static int getFactorial(int a)
        {
            if (a == 1 || a == 0)
            {
                return 1;
            }
            else if (a < 0)
            {
                Console.WriteLine("Invalid number");
                return 0;
            }
            else
            {
                return a * getFactorial(a - 1);
            }
        }
        /*Write a program in C# to print even or odd numbers in a given range using recursion.
Test Data :
Input the range to print starting from 1 : 20
Expected Output :
All even numbers from 1 to 20 are :
2 4 6 8 10 12 14 16 18 20

All odd numbers from 1 to 20 are :
1 3 5 7 9 11 13 15 17 19*/

        static void getEvenRange(int a, int b)
        {
            if (a > b)
            {
                return;

            } else if (a % 2 == 0)
            {
                Console.Write(a + ", ");
            }
            else if (a == b)
            {
                Console.Write(a + " ");
            }
            getEvenRange(a + 1, b);
        }


        static void getOddRange(int a, int b)
        {
            if (a > b)
            {
                return;
            }
            else if (a % 2 == 1)
            {
                Console.Write(a + ", ");
            }
            else if (a == b)
            {
                Console.Write(a + " ");
            }
            getOddRange(a + 1, b);
        }
        /* Write a program in C# Sharp to display a right angle triangle with an asterisk.
 The pattern like :

 *
 **
 ***
 *****/

        static void getRightAngleTri(int a)
        {

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        /* Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.

    *
   **
  ***
 ****    */
        //Done by site refrences NEEDED TO LEARN HOW TO USE THE FOR LOOP......
        static void getPyramidTri(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        /*Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
Test Data :
Input the number or terms :5
Expected Output :
9 99 999 9999 99999
The sum of the series = 111105*/

        static void getSum(int a)
        {

        }
        /* Write a program in C# Sharp to find prime numbers within a range of numbers.
 Test Data :
 Input starting number of range: 1
 Input ending number of range : 50
 Expected Output :
 The prime number between 1 and 50 are :
 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47*/

        static void getPrimeNum(int a, int b)
        {
            if (a == 0 || a == 1)
            {
                return;
            }
            else
            {
                for (int i = 2; i <= a / 2; i++)
                {
                    if (a % i == 0)
                    {
                        return;
                    }
                    Console.Write(a + ", ");
                }

            }
            getPrimeNum(a + 1, b);
        }
        /*Write a C# Sharp program to display your First name character an alphabet pattern with an asterisk.*/

        static void getChar(string a)
        {
            for(int i = 1; i <= a.Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        /*Write a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state below:
Temp< 0 then Freezing weather
Temp 0-10 then Very Cold weather
Temp 10-20 then Cold weather
Temp 20-30 then Normal in Temp
Temp 30-40 then Its Hot
Temp >=40 then Its Very Hot
Test Data :
42
Expected Output :
Its very hot.*/

        static void getTemp(int temp)
        {
           if(temp < 0)
           {
                Console.WriteLine("Freezing weather");
           }
           else if(temp >= 0 && temp <= 10) 
            {
                Console.WriteLine("Very Cold Weather");
            }
           else if(temp >= 10 && temp <= 20)
            {
                Console.WriteLine("Cold Weather");
            }
            else if (temp >= 20 && temp <= 30)
            {
                Console.WriteLine("normal Tempature");
            }
            else if (temp >= 30 && temp <= 40)
            {
                Console.WriteLine("Its Hot");
            }
            else if (temp >= 40)
            {
                Console.WriteLine("Its very Hot");
            }
            else
            {
                Console.WriteLine("Invalid Temprature");
            }
        }
        /*Write a program in C# Sharp to accept a grade and declare the equivalent description :
Grade   Description
E   Excellent
V   Very Good
G Good
A Average
F Fail
Test Data :
Input the grade :a
Expected Output :
You have chosen : Average*/

        static void getGrade()
        {
            Console.WriteLine("Input the Grade; ");
            char a = Convert.ToChar(Console.ReadLine()); 

            switch(Char.ToUpper(a))
            {
                case 'E':
                    Console.WriteLine("Excelent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default: 
                    Console.WriteLine("Invalid Grades");
                    break;
            }
        }
       /* Write a C# Sharp program to check whether a given number is positive or negative.
Test Data : 14
Expected Output :
14 is a positive number
*/
          static void checkWeather()

        {
            Console.Write("Input the number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 0)
            {
                Console.WriteLine($"{a} is a positive number");
            }else
            {
                Console.WriteLine($"{a} is negative number");
            }
        }
        /*Write a C# Sharp program to find out whether a given year is a leap year or not.
Test Data : 2016
Expected Output :
2016 is a leap year.*/
        static bool isLeapYear(int a)
        {
            return (a % 4 == 0 && a % 100 != 0) || (a % 400 == 0);
        }
    }

}