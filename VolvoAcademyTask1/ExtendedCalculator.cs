using System.Text.RegularExpressions;

namespace VolvoAcademyTask1
{
    /// <summary>
    /// Calculator with super additional conditions
    /// </summary>
    public static class ExtendedCalculator
    {

        public static void Start()
        {
            Console.WriteLine($"***Hello, this is extended calculator! Feel free to use it! (type '{HelperTerms.Exit.ToUpper()}' to end)***\n");
            while (true)
            {
                Console.WriteLine("\n*Please enter mathematical expression - first number, chosen operation and second number.\n(in case of factorial type only one number and proper operation sign)*");
                Console.WriteLine("List of available mathematical operations:\n'+' - addition\n'-' - subtraction\n'*' - multiplication\n'/' - division\n" +
                            "'^' - exponentiation (first nuber to the power of second number)\n'!' - factorial\n");
                string? userInput = Console.ReadLine();
                userInput = Regex.Replace(userInput, @"\s+", "");

                string pattern = @"([+-]?\d*\.\d+|[+-]?\d+)([-+*/^]?)([+-]?\d*\.\d+|[+-]?\d+)$";
                string factorialPattern = @"^([+-]?\d*\.\d+|[+-]?\d+)(!)$";
                Match patternMatch = Regex.Match(userInput, pattern);
                bool isFactorialPatternCurrent = false;

                //if pattern does not match, check factorialPattern
                if (!patternMatch.Success)
                {
                    patternMatch = Regex.Match(userInput, factorialPattern);
                    isFactorialPatternCurrent = true;
                }

                if (userInput.ToLower() == HelperTerms.Exit)
                {
                    break;
                }

                if (patternMatch.Success)
                {
                    double firstNumber = double.Parse(patternMatch.Groups[1].Value);

                    string mathSign = Convert.ToString(patternMatch.Groups[2].Value);

                    if (!isFactorialPatternCurrent)
                    {
                        double secondNumber = double.Parse(patternMatch.Groups[3].Value);

                        ParseUserInput(firstNumber, mathSign, secondNumber);
                    }
                    else
                    {
                        if (!MathFunctions.IsInteger(firstNumber))
                        {
                            Console.WriteLine($"{firstNumber} is not an Integer, so we can not calculate factorial!\n");
                        }
                        else if (firstNumber < 0)
                        {
                            Console.WriteLine($"{firstNumber} is negative, so we can not calculate factorial!\n");
                        }
                        else
                        {
                            Console.WriteLine($"{firstNumber}! = {MathFunctions.CalculateFactorial(firstNumber)}");
                        }
                    }


                }
                else
                {
                    Console.WriteLine("ERROR: improper expression! Try entering expression again!\n");
                }

            }
        }

        private static void ParseUserInput(double firstNumber, string mathSign, double secondNumber)
        {
            switch (mathSign)
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
                    if(secondNumber == 0)
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
                default:
                    Console.WriteLine("ERROR: improper math operation (improper math sign)!\n");
                    break;
            }
        }
    }
}