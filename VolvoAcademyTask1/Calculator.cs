using System.Text.RegularExpressions;

namespace VolvoAcademyTask1
{
    /// <summary>
    /// Calculator with additional conditions
    /// </summary>
    public static class Calculator
    {
        public static void Start()
        {
            Console.WriteLine($"***Hello, this is simple calculator! Feel free to use it! (type '{HelperTerms.Exit.ToUpper()}' to end)***\n");
            while (true)
            {
                Console.WriteLine("\n*Please enter first number:*");
                string? userInput = Console.ReadLine();
                userInput = Regex.Replace(userInput, @"\s+", "");
                if (userInput.ToLower() == HelperTerms.Exit)
                {
                    break;
                }
                if (double.TryParse(userInput, out var firstNumber))
                {
                    Console.WriteLine("*Please enter second number:*");
                    userInput = Console.ReadLine();
                    if (userInput?.ToLower() == HelperTerms.Exit)
                    {
                        break;
                    }
                    if (double.TryParse(userInput, out var secondNumber))
                    {
                        Console.WriteLine("*Pick math operation to do:*");
                        Console.WriteLine("'+' - addition\n'-' - subtraction\n'*' - multiplication\n'/' - division\n" +
                            "'^' - exponentiation (first nuber to the power of second number)\n'!' - factorial\n");
                        userInput = Console.ReadLine();
                        if (userInput?.ToLower() == HelperTerms.Exit)
                        {
                            break;
                        }

                        ParseUserInput(userInput, firstNumber, secondNumber);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: improper second number! Try entering numbers again!\n");
                    }

                }
                else
                {
                    Console.WriteLine("ERROR: improper first number! Try entering numbers again!\n");
                }

            }
        }

        private static void ParseUserInput(string? userInput, double firstNumber, double secondNumber)
        {
            switch (userInput)
            {
                case "+":
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {MathFunctions.CalculateSum(firstNumber, secondNumber)}");
                    break;
                case "-":
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {MathFunctions.CalculateDifference(firstNumber, secondNumber)}");
                    break;
                case "*":
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {MathFunctions.CalculateProduct(firstNumber, secondNumber)}");
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("You can not divide by zero!");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {MathFunctions.CalculateQuotient(firstNumber, secondNumber)}");
                    }
                    break;
                case "^":
                    Console.WriteLine($"{firstNumber} ^ {secondNumber} = {MathFunctions.CalculateExponential(firstNumber, secondNumber)}");
                    break;
                case "!":
                    if (MathFunctions.IsInteger(firstNumber) && firstNumber >= 0)
                    {
                        Console.WriteLine($"{firstNumber}! = {MathFunctions.CalculateFactorial(firstNumber)}");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} is not an Integer or it is negative, so we can not calculate factorial!\n");
                    }
                    if (MathFunctions.IsInteger(secondNumber) && secondNumber >= 0)
                    {
                        Console.WriteLine($"{secondNumber}! = {MathFunctions.CalculateFactorial(secondNumber)}");
                    }
                    else
                    {
                        Console.WriteLine($"{secondNumber} is not an Integer or it is negative, so we can not calculate factorial!\n");
                    }
                    break;
                default:
                    Console.WriteLine("ERROR: improper math operation! Try entering numbers and correct operation again!\n");
                    break;


            }
        }
    }
}