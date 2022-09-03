internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes a three-digit number as input and outputs the second digit of that number

        // Clear the console from the previous launch of the program
        Console.Clear();

        // Second digit search function (method)
        int CalcSecondDigit(int x)
        {
            int result = x / 10 % 10;
            return result;
        }

        // Definition of input number
        Console.Write("Enter a three-digit number: ");

        // Checking the number entered by the user and start the calculations
        // Using the try...catch construct
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            // Using logical operator OR (symbol "||")
            if (number < 100 || number >= 1000) Console.WriteLine("Invalid number entered");
            else
            {
                // To test the operation of the algorithm, remove the comment to activate the command: Console.WriteLine("Number entered correctly");
                // Calling a function (method) and returning the result to a variable
                var secondDigit = CalcSecondDigit(number);
                // Displaying the result on the screen
                Console.WriteLine($"The second digit of {number} is {secondDigit}");
            }
        }
        catch
        {
            Console.WriteLine("Need to enter number or the entered number is too large");
        }
    }
}
