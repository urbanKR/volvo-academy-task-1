namespace VolvoAcademyTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pass extended-calc to open ExtendedCalculator
            if(args?.Length > 0 && args[0] == "extended-calc")
            {
                ExtendedCalculator.Start();
            }
            else
            {
                Calculator.Start();
            }

            //these calculators use double values, but if we would like to be more precise in some calculations
            // we could use decimal instead
        }
    }
    }