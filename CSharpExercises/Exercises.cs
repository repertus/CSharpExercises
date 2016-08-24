using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            return "Hello " + name + "!";
            
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide(decimal x, decimal y)
        {
            return x / y;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string fullName)
        {
            return fullName.Split(' ')[0];
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string text)
        {
            char[] charArray = text.ToCharArray();
            string reverse = String.Empty;
        
            for (int i = text.Length -1; i>-1; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new String(charArray);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
        public static string PrintTimesTable(int value)
        {
            int multiValue = 0;
            string[] tableString = new string[10];
            string times = " * ";
            string equal = " = ";
            int timesValue = 0;

            for (int i = 0; i < 10; i++)
            {
                timesValue = timesValue + 1;
                multiValue = value * timesValue;
                tableString[i] = string.Concat(value.ToString(), times, timesValue.ToString(), equal, multiValue.ToString());
            }
            return string.Join("\r\n", tableString);
        }
        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double kelvin)
        {
            double factor = 9d / 5d;
            return Math.Round(((kelvin * factor) - 459.67d), 2);
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] values)
        {
            double total = 0;
            double valueLength = values.Length;

            for (int i = 0; i < values.Length; i++)
            {
                total = total + values[i];
            }
            return total/valueLength;
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] values)
        {
            return (double) values.Average();
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
        public static string DrawTriangle(int number, int width)
        {
            string[] row = new string[width];
            string[] triangleArray = new string[width];
            int height = width;

            for (int r = 0; r < height; r++ ) //change to r
            { 
                for (int c = 0; c < width; c++) //change to c
                {
                    row[c] = string.Concat(number.ToString()); // change to c
                } 
                triangleArray[r] = string.Concat(row);//change to r
                Array.Clear(row, 0, width);
                width = width - 1;
                Array.Resize(ref row, width);//
            }
            return string.Join("\r\n", triangleArray);
        }
        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double dist, int hrs, int min, int sec)
        {
            double hrs_travelled = 0;
            double mph = 0;

            hrs_travelled = (((double)sec / 3600d) + ((double)min / 60d) + ((double)hrs));
            mph = Math.Ceiling(dist / hrs_travelled);
                    
            return mph.ToString() + "MPH";
        }
        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char parameter)
        {

            return new[] { 'a', 'e', 'i', 'o', 'u' }.Contains(char.ToLower(parameter));
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char parameter)
        {
            bool consonant = true;

            if (new[] { 'a', 'e', 'i', 'o', 'u' }.Contains(char.ToLower(parameter)) == true)
            {
                consonant = false;
            }

            return consonant;
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int value)
        {
            int remainder;
            int step = 0;
            
            while (value != 1)
            {
                remainder = value % 2;
                if (remainder == 0)
                {
                    value = value / 2;
                    step = step + 1;
                }
                else
                {
                    value = (value * 3) + 1;
                    step = step + 1;
                }
            }

            return step;
        }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime day)
        {
            DateTime[] week = new DateTime[7];

            for (int i = 0; i <= 6; i++)
            {
                week[i] = day.AddDays(i);
            }
            return week;
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsLeapYear(DateTime date)
        {
            int year_int = date.Year;
            var nextYear = new DateTime(year_int + 1, 1, 1);
            bool test;

            var days = (nextYear - date).Days;

            if (days == 366)
            {
                test = true;
            }
            else
            {
                test = false;
            }
            return test;
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static decimal MortgageCalculator(decimal loanBalance, decimal interestRate, int loanTerm, int periodSelection)
        {
            double numberOfMonths;
            double monthlyInterestRate;

            //Number of monthly or bi-monthly payments
            if (periodSelection == 1)
            {   
                numberOfMonths = loanTerm * 12;
                monthlyInterestRate = ((double)interestRate / 100d) / 12d;
            }
            else
            {
                numberOfMonths = loanTerm * 6;
                monthlyInterestRate = ((double)interestRate / 100d) / 6d;
            }

            //Compounded interest rate
            double compoundedInterestRate = Math.Pow((1 + monthlyInterestRate), numberOfMonths);

            //Interest quotient
            double interestQuotient = (monthlyInterestRate * compoundedInterestRate) / (compoundedInterestRate - 1);

            //Final calculation rounded to two decimal places
            double monthlyPayment = Math.Round((((double)loanBalance * interestQuotient) * 100d) / 100d,2);

            return (decimal) monthlyPayment;

        }
        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */
        public static string DuckGoose(int value)
        {
            string[] game = new string[value];

            for (int i = 0; i < value; i++)
            {
                int devisableBy3 = (i + 1) % 3;
                int devisableBy5 = (i + 1) % 5;

                if (devisableBy3 == 0 & devisableBy5 == 0)
                {
                    game[i] = string.Concat("DuckGoose");
                }
                else if (devisableBy3 == 0)
                {
                    game[i] = string.Concat("Duck");
                }
                else if (devisableBy5 == 0)
                {
                    game[i] = string.Concat("Goose");
                }
                else
                {
                    game[i] = (i+1).ToString();
                }
 
            }

            return string.Join("\r\n", game);
        }
        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}