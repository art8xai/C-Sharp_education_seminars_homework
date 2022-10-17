internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program to calculate the Ackermann function using recursion. Two non-negative numbers m and n are given.
        // m = 2, n = 3 -> A(m,n) = 9
        // m = 3, n = 2 -> A(m,n) = 29

        // More information about the Ackermann function: https://en.wikipedia.org/wiki/Ackermann_function

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // A function (method) that calculates the Ackermann function using recursion.
        int GetCalcAckermannFunction(int m, int n)
        {
            int result = 0;

            if (m == 0)
            {
                result = n + 1;
            }

            if (m > 0 && n == 0)
            {
                result = GetCalcAckermannFunction(m - 1, 1);
            }

            if (m > 0 && n > 0)
            {
                result = GetCalcAckermannFunction(m - 1, GetCalcAckermannFunction(m, n - 1));
            }

            return result;
        }

        // User inputs numbers. Checking entered numbers.
        int m = 0;
        int n = 0;

        Console.Write("Enter number (m): ");
        bool parseIsOk = int.TryParse(Console.ReadLine(), out int number);
        if (!parseIsOk)
        {
            Console.Write("Invalid format value entered");
            return;
        }
        else if (number < 0)
        {
            Console.Write("Please enter a non-negative number");
            return;
        }
        else m = number;

        Console.Write("Enter number (n): ");
        parseIsOk = int.TryParse(Console.ReadLine(), out number);
        if (!parseIsOk)
        {
            Console.Write("Invalid format value entered");
            return;
        }
        else if (number < 0)
        {
            Console.Write("Please enter a non-negative number");
            return;
        }
        else n = number;

        // Calling a function (method), returning the result to a variable and displaying the result on the screen.
        var calcAckermannFunction = GetCalcAckermannFunction(m, n);
        Console.WriteLine($"A({m},{n}) = {calcAckermannFunction}");
    }
}
