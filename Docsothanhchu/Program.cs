using System;

public class NumberToWords
{
    public static void Main(string[] args)
    {
        int number;
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.Write("Enter the number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                isValidInput = true;
                Console.WriteLine("Your number is: " + number);
                Console.WriteLine(ReadNumber(number));
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }

    public static string ReadNumber(int number)
    {
        if (number < 0 || number > 999)
        {
            return "out of ability";
        }

        if (number < 10)
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
            }
        }

        if (number < 20)
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
            }
        }

        if (number < 100)
        {
            int tens = number / 10;
            int ones = number % 10;
            string tensText = "";

            switch (tens)
            {
                case 2: tensText = "twenty"; break;
                case 3: tensText = "thirty"; break;
                case 4: tensText = "forty"; break;
                case 5: tensText = "fifty"; break;
                case 6: tensText = "sixty"; break;
                case 7: tensText = "seventy"; break;
                case 8: tensText = "eighty"; break;
                case 9: tensText = "ninety"; break;
            }

            if (ones != 0)
            {
                tensText += " " + ReadNumber(ones);
            }

            return tensText;
        }

        if (number < 1000)
        {
            int hundreds = number / 100;
            int remainder = number % 100;
            string hundredsText = ReadNumber(hundreds) + " hundred";

            if (remainder != 0)
            {
                hundredsText += " and " + ReadNumber(remainder);
            }

            return hundredsText;
        }

        return "";
    }
}

