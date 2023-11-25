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
                        double sum = firstNumber + secondNumber;
                        Console.WriteLine("*Pick math operation to do:*");
                        Console.WriteLine("'+' - addition\n'-' - subtraction\n'*' - multiplication\n'/' - division\n" +
                            "'^' - exponentiation\n'!' - factorial");
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
    }
}