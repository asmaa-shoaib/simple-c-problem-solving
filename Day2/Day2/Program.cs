using System;

namespace Day2
{
    class Program
    {

        //  C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.

        public static bool ranging(int n1, int n2)
        {
            if ((n1 >= 100 && n1 <= 200) || (n2 >= 100 && n2 <= 200))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.
        public static bool multiple37(int x)
        {
            if (x > 0)
            {

                if (x % 3 == 0 || x % 7 == 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("the number isn`t multiple by 3 || 7");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("the number isn`t positive");
                return false;
            }
        }


        //C# Sharp program to compute the sum of the two given integer values.
        //If the two values are the same, then return triple their sum.
        public static int sum(int x, int y)
        {
            if (x != y)
            {
                return x + y;
            }
            else
            {
                return (x + y) * 3;
            }
        }

        //C# Sharp program to get the absolute difference between n and 51.
        //If n is greater than 51 return triple the absolute difference.
        public static int diff(int n)
        {
            int x = 51 - n;
            if (x >= 0)
            {
                return 3 * x;
            }
            else
            {
                return x * -1;
            }
        }

        // C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
        public static bool check(int n, int k)
        {

            if (n == 30 || k == 30 || n + k == 30)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // C# Sharp program to check whether three given integer values are in the range 20..50 inclusive.
        // Return true if 1 or more of them are in the said range otherwise false.

        public static bool rangingThreeNum(int n1, int n2, int n3)
        {
            if ((n1 >= 20 && n1 <= 50) || (n2 >= 20 && n2 <= 50) || (n3 >= 20 && n3 <= 50))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //C# Sharp program to check the largest number among three given integers.

        public static int largestAmongThree(int n1, int n2, int n3)
        {
            if (n1 >= n2 && n1 >= n3)
            {
                return n1;
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                return n2;
            }
            else if (n3 >= n1 && n3 >= n2)
            {
                return n3;
            }
            else
            {
                Console.WriteLine("there are error");
                return 0;
            }
        }

        //C# Sharp program to check which number nearest to the value 100 among two given integers.
        //Return 0 if the two numbers are equal.
        public static int Handerddiv(int n1, int n2)
        {
            if (n1 == n2)
            {
                Console.WriteLine($"numbers are equal and the distance is 100-{n1}");
                return 0;
            }
            else
            {
                int sub1 = 100 - n1;
                if (sub1 < 0) { sub1 = sub1 * -1; }

                int sub2 = 100 - n2;
                if (sub2 < 0) { sub2 = sub2 * -1; }

                if (sub1 < sub2)
                {
                    Console.WriteLine($"{n1} is nearstto 100");
                    return sub1;
                }
                else if (sub1 > sub2)
                {
                    Console.WriteLine($"{n2} is nearstto 100");
                    return sub2;
                }
                else
                {
                    Console.WriteLine($"the distance betwwen {n1} , {n2} are equal and its equal to {sub1}");
                    return 0;
                }
            }
        }
        //C# Sharp program to check whether two given integers are in the range 40..50 inclusive
        //, or they are both in the range 50..60 inclusive.


        public static bool Check_range_4050_5060(int n1, int n2)
        {
            if ((n1 >= 40 && n1 <= 50 && n2 >= 40 && n2 <= 50) || (n1 >= 50 && n1 <= 60 && n2 >= 50 && n2 <= 60))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive,
        //or return 0 if neither is in that range.

        public static int checkRange(int n1, int n2)
        { if (n1 < 0 || n2 < 0)
            {
                return 0;
            }
            else
            {
                if (n1 >= 20 && n1 <= 30 && n2 >= 20 && n2 <= 30)
                {
                    if (n1 >= n2)
                    {
                        return n1;
                    }
                    else
                    {
                        return n2;
                    }
                }
                else
                {
                    return 0;
                }
            }

        }

        //loops 
        //C# Sharp program to create a new string which is n (non-negative integer) copies of a given string.
        public static string creatingString(string str, int n)
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += str;
            }
            return s;
        }


        //C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5.

        public static bool check5(int n1, int n2)
        {
            if (n1 == 5 || n2 == 5 || n1 + n2 == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both.

        public static bool multiple73NotBoth(int n1)
        {
            if (n1 % 3 == 0 && n1 % 7 == 0)
            {
                return false;

            } else if (n1 % 3 == 0 || n1 % 7 == 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        //Write a C# Sharp program to check whether a given number is divisible by 3 return
        //"Fizz" and return "Buzz" if it divisible by 5 and return "FizzBuzz" If it divisible by 3 and 5

        public static string FizzBuzz(int n)
        {
            string str = "";
            if (n % 3 == 0 && n % 5 != 0)
            {
                str = "Buzz";
            }
            else if (n % 3 != 0 && n % 5 == 0)
            {
                str = "Fizz";
            }
            else if (n % 3 == 0 && n % 5 == 0)
            {
                str = "FizzBuzz";
            }
            else
            {
                str = "";
            }
            return str;
        }

        //C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers.
        public static bool checkThirdValue(int n1, int n2, int n3)
        {
            if (n1 + n2 == n3)
            {
                return true;
            }
            return false;
        }
        // Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.
        public static bool chechGreater(int x, int y, int z)
        {
            if (x < y && z > y)
            {
                return true;
            }

            return false;
        }

        // Create Multiplication Table
        public static void Multiplication()
        {
            string str = "";
            for (int i = 1; i < 13; i++)
            {
                for (int j = i; j < 13; j++)
                {
                    str = str + $"{i}*{j}={i * j} ";
                }
                Console.WriteLine(str);
                str = "";
            }
        }
        //
        // receive 3 positive numbers from user and display max and min of them
        public static void Max_Min(int n1, int n2, int n3)
        {
            int max = 0; int min = 0;
            if (n1 >= n2 && n1 >= n3)
            {
                max = n1;
                if (n2 >= n3) { min = n3; }
                else { min = n2; }
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                max = n2;
                if (n1 >= n3) { min = n3; }
                else { min = n1; }
            }
            else
            {
                max = n3;
                if (n2 >= n1) { min = n1; }
                else { min = n3; }
            }
            Console.WriteLine($"the max :{max} ,the min :{min}");

        }


        //enter num and display even ,odd between them sum evens ,odds and find the abs of them dem sub

        public static void Evens_Odds(int s ,int e)
        {
            int sumOfEvens = 0;
            int sumOfOdds = 0;
            string odd = "";
            string even = "";
            for (int i = s; i <= e; i++)
            {
                if (i % 2 == 0) { 
                    even += i+ " ";
                    sumOfEvens += i;
                } 
                else
                {
                    odd += i + " ";
                    sumOfOdds += i;
                }

            }
            int diff = sumOfEvens - sumOfOdds;
            if (diff <0)
            {
                diff = diff * -1;
            }
            Console.WriteLine($"odds : ( {odd}) ,sum of odd = {sumOfOdds} ");
            Console.WriteLine($"evens : ( {even}) ,sum of even = { sumOfEvens}  ");
            Console.WriteLine($"the diffrance between o & e is {diff}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //C# Sharp program to compute the sum of the two given integer values.
            //If the two values are the same, then return triple their sum.
            int z = sum(2, 3);
            Console.WriteLine($"the sum :{ z}");

            int x = sum(3, 3);
            Console.WriteLine($"the sum2 :{ x}");


            //C# Sharp program to get the absolute difference between n and 51.
            //If n is greater than 51 return triple the absolute difference.
            int y = diff(50);
            Console.WriteLine($"the diff :{ y}");

            int y1 = diff(59);
            Console.WriteLine($"the diff1 :{ y1}");

            int y2 = diff(51);
            Console.WriteLine($"the diff2 :{ y2}");

            // C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
            bool check1 = check(29, 25);
            Console.WriteLine($"the check1 :{ check1}");

            bool check2 = check(30, 25);
            Console.WriteLine($"the check2 :{ check2}");

            bool check3 = check(30, 25);
            Console.WriteLine($"the check3 :{ check3}");

            bool check4 = check(15, 15);
            Console.WriteLine($"the check4 :{ check4}");

            //C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.

            bool multiple = multiple37(32);
            Console.WriteLine($"the multiple :{ multiple}");


            bool rangingVar = ranging(100, 50);
            Console.WriteLine($"ranging resualt is : {rangingVar}");


            bool rangingVar1 = ranging(201, 520);
            Console.WriteLine($"ranging resualt is : {rangingVar1}");


            bool rangingVar2 = ranging(10, 150);
            Console.WriteLine($"ranging resualt is : {rangingVar2}");

            bool rangingThreeNum1 = rangingThreeNum(5, 20, 10);
            Console.WriteLine($"rangingThreeNum resualt is : {rangingThreeNum1}");

            bool rangingThreeNum2 = rangingThreeNum(52, 0, 10);
            Console.WriteLine($"rangingThreeNum resualt is : {rangingThreeNum2}");

            bool rangingThreeNum3 = rangingThreeNum(50, 20, 15);
            Console.WriteLine($"rangingThreeNum resualt is : {rangingThreeNum3}");

            //C# Sharp program to check the largest number among three given integers.

            int largestAmongThree1 = largestAmongThree(2, 5, 10);
            Console.WriteLine($"largestAmongThree(2, 5, 10) resualt is : {largestAmongThree1}");


            int largestAmongThree2 = largestAmongThree(2, 2, 2);
            Console.WriteLine($"largestAmongThree(2, 2 , 2) resualt is : {largestAmongThree2}");

            int largestAmongThree3 = largestAmongThree(5, 5, 10);
            Console.WriteLine($"largestAmongThree(5, 5, 10) resualt is : {largestAmongThree3}");

            int largestAmongThree4 = largestAmongThree(2, 5, 1);
            Console.WriteLine($"largestAmongThree(2, 5, 1) resualt is : {largestAmongThree4}");

            int largestAmongThree5 = largestAmongThree(2, 10, 10);
            Console.WriteLine($"largestAmongThree(2, 10, 10) resualt is : {largestAmongThree5}");


            //C# Sharp program to check which number nearest to the value 100 among two given integers.
            //Return 0 if the two numbers are equal.

            int handerddiv1 = Handerddiv(100, 101);
            Console.WriteLine($" the handerddiv1 result is :{handerddiv1} ");


            int handerddiv2 = Handerddiv(50, 10);
            Console.WriteLine($" the handerddiv2 result is :{handerddiv2} ");


            int handerddiv3 = Handerddiv(90, 90);
            Console.WriteLine($" the handerddiv3 result is :{handerddiv3} ");


            int handerddiv4 = Handerddiv(90, 110);
            Console.WriteLine($" the handerddiv4 result is :{handerddiv4} ");

            bool CheckRange1 = Check_range_4050_5060(25, 50);
            Console.WriteLine($" the Check_range_4050_50601 result is :{CheckRange1} ");

            bool CheckRange2 = Check_range_4050_5060(65, 50);
            Console.WriteLine($" the Check_range_4050_50602 result is :{CheckRange2} ");

            bool CheckRange3 = Check_range_4050_5060(45, 48);
            Console.WriteLine($" the Check_range_4050_50603 result is :{CheckRange3} ");

            bool CheckRange4 = Check_range_4050_5060(55, 52);
            Console.WriteLine($" the Check_range_4050_50604 result is :{CheckRange4} ");

            bool CheckRange5 = Check_range_4050_5060(35, 25);
            Console.WriteLine($" the Check_range_4050_50605 result is :{CheckRange5} ");

            bool CheckRange6 = Check_range_4050_5060(65, 70);
            Console.WriteLine($" the Check_range_4050_50601 result is :{CheckRange6} ");

            //C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive,
            //or return 0 if neither is in that range.

            int checkRange1 = checkRange(20, 30);
            Console.WriteLine($"checkRange(20, 30) is : {checkRange1}");


            int checkRange2 = checkRange(-20, -30);
            Console.WriteLine($"checkRange(-20, -30) is : {checkRange2}");


            int checkRange3 = checkRange(22, 25);
            Console.WriteLine($"checkRange(22, 25) is : {checkRange3}");


            int checkRange4 = checkRange(25, 31);
            Console.WriteLine($"checkRange(25, 31) is : {checkRange4}");

            string str = creatingString("js", 1);
            Console.WriteLine(str);

            //C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5.

            bool check51 = check5(20, 5);
            Console.WriteLine($"the result of check5(20, 5) is {check51}");

            bool check52 = check5(4, 3);
            Console.WriteLine($"the result of check5(4, 3) is {check52}");

            bool check53 = check5(1, 4);
            Console.WriteLine($"the result of check5(1 , 4) is {check53}");

            bool multiple73NotBoth1 = multiple73NotBoth(21);
            Console.WriteLine($"the result of multiple73NotBoth(21) is {multiple73NotBoth1}");


            bool multiple73NotBoth2 = multiple73NotBoth(15);
            Console.WriteLine($"the result of multiple73NotBoth(15) is {multiple73NotBoth2}");


            bool multiple73NotBoth3 = multiple73NotBoth(49);
            Console.WriteLine($"the result of multiple73NotBoth(49) is {multiple73NotBoth3}");

            //Write a C# Sharp program to check whether a given number is divisible by 3 return
            //"Fizz" and return "Buzz" if it divisible by 5 and return "FizzBuzz" If it divisible by 3 and 5
            string str1 = FizzBuzz(12);
            Console.WriteLine($"str1 : {str1}");


            string str2 = FizzBuzz(15);
            Console.WriteLine($"str2 : {str2}");


            string str3 = FizzBuzz(5);
            Console.WriteLine($"str3 : {str3}");


            string str4 = FizzBuzz(9);
            Console.WriteLine($"str4 : {str4}");

            //C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers.

            bool checkThirdValue1 = checkThirdValue(1, 2, 3);
            bool checkThirdValue2 = checkThirdValue(5, 4, 9);
            bool checkThirdValue3 = checkThirdValue(1, 3, 3);

            Console.WriteLine($"{checkThirdValue1} \t {checkThirdValue2} \t {checkThirdValue3}");
            //Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.
            bool chechGreater1 = chechGreater(1, 0, 5);

            bool chechGreater2 = chechGreater(1, 2, 5);
            bool chechGreater3 = chechGreater(1, 0, -5);


            Console.WriteLine($"{chechGreater1} \t {chechGreater2} \t {chechGreater3}");
            //Create Multiplication Table
            Multiplication();
            //receive 3 positive numbers from user and display max and min of them
            Max_Min(5, 10, 15);
            Max_Min(5, 10, 1);
            Max_Min(50, 10, 15);
            Max_Min(51, 10, 1);
            //receive positive numbers from user until summation of them reached or exceed 400
            int limit = 0;
            do {
                Console.Write($"enter num less than 400  :\t");
                int input = int.Parse(Console.ReadLine());
                limit += input;
            } while (limit < 400);
            Console.WriteLine(limit);


            //selection calculatar with given input from user
            bool exit = false;
            do
            {
                Console.WriteLine("select sum of these operation '+' '-' '*' '/' 'e' ");
                string _str = Console.ReadLine();
                int result = 0;
                switch (_str)
                {

                    case "+":
                        Console.Write("enter first oprand : ");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.Write("enter second oprand : ");
                        int x2 = int.Parse(Console.ReadLine());
                        result = x1 + x2;
                        Console.WriteLine(result);
                        break;
                    case "-":
                        Console.Write("enter first oprand : ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.Write("enter second oprand : ");
                        int n2 = int.Parse(Console.ReadLine());
                        result = n1 -n2;
                        Console.WriteLine(result);
                        break;
                    case "*":
                        Console.Write("enter first oprand : ");
                        int w1 = int.Parse(Console.ReadLine());
                        Console.Write("enter second oprand : ");
                        int w2 = int.Parse(Console.ReadLine());
                        result = w1 * w2;
                        Console.WriteLine(result);
                        break;
                    case "/":
                        Console.Write("enter first oprand : ");
                        int d1 = int.Parse(Console.ReadLine());
                        int d2;
                        do
                        {
                            Console.Write("enter second oprand : ");
                            d2 = int.Parse(Console.ReadLine());
                        } while (d2 == 0);
                        result = d1 / d2;
                        Console.WriteLine(result);
                        break;

                    case "e":
                        exit = true;
                        break;
                }
            } while (exit==false);

            Evens_Odds(1, 10);
        }
    }

}