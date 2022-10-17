internal class Program
{
    private static void Main(string[] args)
    {
        // Set the value to N. Write a program that prints all natural integers between N and 1. Execute using recursion. 
        // N = 5 -> "5, 4, 3, 2, 1"
        // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // A function (method) that prints all natural integers from N to 1.
        string GetOutputNumberFromNTo1(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            string result = n + ", " + GetOutputNumberFromNTo1(n - 1);
            return result;
        }

        // User input a number. Checking the entered number.
        int n = 0;
        Console.Write("Enter number (N): ");
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
        else n = number;

        // Calling a function (method), returning the result to a variable and displaying the result on the screen.
        var outputNumberFromNTo1 = GetOutputNumberFromNTo1(n);
        Console.WriteLine($"All integers from N = {n} to 1: {outputNumberFromNTo1}");
    }
}
