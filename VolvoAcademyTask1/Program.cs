namespace VolvoAcademyTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Hello, this is simple calculator! Feel free to use it! (type 'EXIT' to end)***\n");
            string userInput = "";
            while (true)
            {
                Console.WriteLine("*Please enter first number:*");
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "exit")
                {
                    break;
                }
                if (double.TryParse(userInput, out var firstNumber))
                {
                    Console.WriteLine("*Please enter second number:*");
                    userInput = Console.ReadLine();
                    if(userInput.ToLower() == "exit")
                    {
                        break;
                    }
                    if (double.TryParse(userInput, out var secondNumber))
                    {
                        Console.WriteLine("*Pick math operation to do:*");
                        Console.WriteLine("'+' - addition\n'-' - subtraction\n'*' - multiplication\n'/' - division\n" +
                            "'^' - exponentiation (first nuber to the power of second number)\n'!' - factorial");
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == "exit")
                        {
                            break;
                        }
                        
                        switch(userInput)
                        {
                            case "+":
                                Console.WriteLine($"{firstNumber} + {secondNumber} = {CalculateSum(firstNumber, secondNumber)}");
                                break;
                            case "-":
                                Console.WriteLine($"{firstNumber} - {secondNumber} = {CalculateDifference(firstNumber, secondNumber)}");
                                break;
                            case "*":
                                Console.WriteLine($"{firstNumber} * {secondNumber} = {CalculateProduct(firstNumber, secondNumber)}");
                                break;
                            case "/":
                                Console.WriteLine($"{firstNumber} / {secondNumber} = {CalculateQuotient(firstNumber, secondNumber)}");
                                break;
                            case "^":
                                Console.WriteLine($"{firstNumber} ^ {secondNumber} = {CalculateExponential(firstNumber, secondNumber)}");
                                break;
                            case "!":
                                if(IsInteger(firstNumber) && firstNumber >= 0)
                                {
                                    Console.WriteLine($"{firstNumber}! = {CalculateFactorial(firstNumber)}");
                                }
                                else
                                {
                                    Console.WriteLine($"{firstNumber} is not an Integer or it is negative, so we can not calculate factorial!\n");
                                }
                                if (IsInteger(secondNumber) && secondNumber >= 0)
                                {
                                    Console.WriteLine($"{secondNumber}! = {CalculateFactorial(secondNumber)}");
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
        static double CalculateSum(double x, double y)
        {
            return x + y;
        }
        static double CalculateDifference(double x, double y)
        {
            return x - y;
        }
        static double CalculateProduct(double x, double y)
        {
            return x * y;
        }
        static double CalculateQuotient(double x, double y)
        {
            return x / y;
        }
        static double CalculateExponential(double x, double y)
        {
            return Math.Pow(x, y);
        }
        static double CalculateFactorial(double x)
        {
            if(x == 0)
            {
                return 1;
            }
            else
            {
                return x * CalculateFactorial(x - 1);
            }
            
        }
        static bool IsInteger(double x)
        {
            return x == Math.Floor(x);
        }
    }
}