namespace matework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool IsValidScore(double score)
            //{
            //        if (score >= 0 && score <= 100)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }

            //    Console.WriteLine("Enter 3 exam scores (0 - 100)");

            //    Console.Write("Exam 1: ");
            //    double score1 = double.Parse(Console.ReadLine());

            //    Console.Write("Exam 2: ");
            //    double score2 = double.Parse(Console.ReadLine());

            //    Console.Write("Exam 3: ");
            //    double score3 = double.Parse(Console.ReadLine());


            //    if (!IsValidScore(score1) || !IsValidScore(score2) || !IsValidScore(score3))
            //    {
            //        Console.WriteLine("Error: scores must be between 0 and 100!");
            //        return;
            //    }

            //    double average = CalculateAverage(score1, score2, score3);
            //    string grade = GetGrade(average);
            //    bool passed = IsPassed(average);

            //    Console.WriteLine("Average score: " + average.ToString("F2"));
            //    Console.WriteLine("Grade: " + grade);

            //    if (passed)
            //    {
            //        Console.WriteLine("Status: Passed");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Status: Failed");
            //    }
            //}


            //static double CalculateAverage(double s1, double s2, double s3)
            //{
            //    return (s1 + s2 + s3) / 3;
            //}


            //static string GetGrade(double average)
            //{
            //    if (average >= 90)
            //    {
            //        return "A";
            //    }
            //    else if (average >= 80)
            //    {
            //        return "B";
            //    }
            //    else if (average >= 70)
            //    {
            //        return "C";
            //    }
            //    else if (average >= 60)
            //    {
            //        return "D";
            //    }
            //    else
            //    {
            //        return "F";
            //    }
            //}


            //static bool IsPassed(double average)
            //{
            //    return average >= 60;
            //}




            bool IsPositive(int number)
            {
                if (number > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            if (!IsPositive(num))
            {
                Console.WriteLine("The number is not positive.");
                Console.WriteLine("Please enter a number greater than 0.");
                return;
            }

            Console.WriteLine("The number is positive.");

            if (IsEven(num))
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            if (IsPrime(num))
            {
                Console.WriteLine("The number is prime.");
            }
            else
            {
                Console.WriteLine("The number is not prime.");
            }

            Console.WriteLine("Number of digits: " + CountDigits(num));
            Console.WriteLine("Reversed number: " + ReverseNumber(num));
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int CountDigits(int number)
        {
            int count = 0;

            while (number > 0)
            {
                number = number / 10;
                count++;
            }

            return count;
        }

        static string ReverseNumber(int number)
        {
            string result = "";

            while (number > 0)
            {
                int digit = number % 10;
                result = result + digit;
                number = number / 10;
            }

            return result;


        }
    }
}

