

internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes a number (N) as input and produces a table of cubes of numbers from 1 to N.
        // 3 -> 1, 8, 27
        // 5 -> 1, 8, 27, 64, 125

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Function (method) for issuing a table of cubes of numbers from 1 to N.
        string GetTableCubeNumber(int x)
        {
            string result = "";
            for (int i = 1; i <= x; i++)
            {
                result = $"{result}{i * i * i}";
                // Adding a comma after a number.
                if (i < x)
                {
                    result = $"{result}, ";
                }
            }
            return result;
        }

        // Checking the number entered by the user using the try...catch construct and start the calculations.
        try
        {
            // Definition of input number.
            Console.Write("Enter a positive integer number (N) to display the table of cubes up to this number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0) Console.WriteLine("Invalid number entered");
            else 
            {
                // To test the operation of the algorithm, remove the comment to activate the command: Console.WriteLine("Number entered correctly");
                // Calling a function (method) and returning the result to a variable.
                var tableCubeNumber = GetTableCubeNumber(number);
                // Displaying the result on the screen.
                Console.Write(tableCubeNumber);
            }
        }
        catch
        {
            Console.WriteLine("Need to enter integer number or the entered number is too large");
        }
    }
}
