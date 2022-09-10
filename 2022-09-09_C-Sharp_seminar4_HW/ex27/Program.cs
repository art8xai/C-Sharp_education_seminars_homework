internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes a number as input and returns the sum of the digits in the number.
        // 452 -> 11; 82 -> 10; 9012-> 12

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // The function (method) returns the sum of digits in a number.
        int GetSumDigitsNumber(int x)
        {
            int count = x;
            int result = 0;
            while (count >= 10)
            {
                result = result + count % 10;
                count = count / 10;
            }
            result = result + count;
            return result;
        }

        // Checking the number entered by the user using the try...catch construct and start the calculations.
        try
        {
            // Definition of input number.
            Console.Write("Enter a non-negative number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Additional check of the number entered by the user.
            if (number < 0)
            {
                Console.Write("You need to enter a positive integer.");
            }
            else
            {
                // Calling a function (method) and returning the result to a variable.
                var sumDigitsNumber = GetSumDigitsNumber(number);

                // Displaying the result on the screen.
                Console.WriteLine($"The sum of the digits in the number {number} is equal to {sumDigitsNumber}.");
            }
        }
        catch (Exception ex)
        {
            // Error message output.
            Console.WriteLine(ex.Message);
        }
    }
}
