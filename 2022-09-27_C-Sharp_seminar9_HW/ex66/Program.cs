internal class Program
{
    private static void Main(string[] args)
    {
        // Give values ​​M and N. Write a program that will find the sum of natural integers between M and N. 
        // M = 1; N = 15 -> 120
        // M = 4; N = 8 -> 30

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // A function (method) that finds the sum of natural integers from M to N.
        int GetSumNumberFromMToN(int m, int n)
        {
            if (m == n)
            {
                return m;
            }
            int result = n + GetSumNumberFromMToN(m, n - 1);
            return result;
        }

        // User inputs numbers. Checking entered numbers.
        int m = 0;
        int n = 0;

        Console.Write("Enter number (M): ");
        bool parseIsOk = int.TryParse(Console.ReadLine(), out int number);
        if (!parseIsOk)
        {
            Console.Write("Invalid format value entered");
            return;
        }
        else if (number <= 0)
        {
            Console.Write("Please enter a positive number");
            return;
        }
        else m = number;

        Console.Write("Enter number (N): ");
        parseIsOk = int.TryParse(Console.ReadLine(), out number);
        if (!parseIsOk)
        {
            Console.Write("Invalid format value entered");
            return;
        }
        else if (number <= 0)
        {
            Console.Write("Please enter a positive number");
            return;
        }
        else n = number;

        // Calling a function (method), returning the result to a variable and displaying the result on the screen.
        var sumNumberFromMToN = GetSumNumberFromMToN(m, n);
        Console.WriteLine($"The sum of all integers from N = {m} to N = {n}: {sumNumberFromMToN}");
    }
}
