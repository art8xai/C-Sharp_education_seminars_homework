internal class Program
{
    private static void Main(string[] args)
    {
        // Write a loop that takes two numbers (A and B) as input and raises the number A to the natural power of B.
        // 3, 5 -> 243 (3⁵); 2, 4 -> 16

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Function (method) of raising a number to a natural power.
        double GetRaiseNumber(int x, int y)
        {
            // It is accepted that any number (even 0) raised to zero is equal to 1, so 1 was written into the "result" variable.
            // Rationale: In algebra and combinatorics, the generally agreed upon value is 0 to the power of 0 equals 1,
            // whereas in mathematical analysis, the expression is sometimes left undefined.
            // To learn more https://en.wikipedia.org/wiki/Zero_to_the_power_of_zero
            double result = 1;
            if (y > 0)
            {
                for (int i = 1; i <= y; i++)
                {
                    result = result * x;
                }
            }
            if (y < 0)
            {
                for (int i = -1; i >= y; i--)
                {
                    result = result * 1 / x;
                }
            }
            return result;
        }

        // Checking the number entered by the user using the try...catch construct and start the calculations.
        try
        {
            // Definition of input numbers.
            Console.Write("Enter a integer number A: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a integer number B: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            // Additional check of the number entered by the user.
            if ((numberA == 0) && (numberB < 0))
            {
                Console.Write("You can't raise 0 to a negative power.");
            }
            else
            {
                // Calling a function (method) and returning the result to a variable.
                var raiseNumber = GetRaiseNumber(numberA, numberB);

                // Displaying the result on the screen.
                Console.WriteLine($"The number {numberA} in natural power {numberB} is {raiseNumber}.");
            }
        }
        catch (Exception ex)
        {
            // Error message output.
            Console.WriteLine(ex.Message);
        }
    }
}
