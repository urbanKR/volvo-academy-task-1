namespace VolvoAcademyTask1
{
    public static class MathFunctions
        {
            public static double CalculateSum(double x, double y)
            {
                return x + y;
            }
            public static double CalculateDifference(double x, double y)
            {
                return x - y;
            }
            public static double CalculateProduct(double x, double y)
            {
                return x * y;
            }
            public static double CalculateQuotient(double x, double y)
            {
                return x / y;
            }
            public static double CalculateExponential(double x, double y)
            {
                return Math.Pow(x, y);
            }
            public static double CalculateFactorial(double x)
            {
                if (x == 0)
                {
                    return 1;
                }
                else
                {
                    return x * CalculateFactorial(x - 1);
                }

            }
            public static bool IsInteger(double x)
            {
                return x == Math.Floor(x);
            }
        }
    }