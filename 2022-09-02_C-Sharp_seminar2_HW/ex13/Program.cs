internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that displays the third digit of a given number, or reports that there is no third digit

        // Clear the console from the previous launch of the program
        Console.Clear();

        // Third digit search function (method)
        void CalcThirdDigit(int x)
        {
            if (x >= 100)
            {
                int count = x;
                while (count >= 1000)
                {
                    count = count / 10;
                }
                int result = count % 10;
                // Displaying the result on the screen
                Console.WriteLine($"The third digit of {x} is {result}");
            }
            else Console.WriteLine("No third digit");
        }

        // Definition of input number
        Console.Write("Enter a number: ");

        // Checking the number entered by the user and start the calculations
        // Using the try...catch construct
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            // To test the operation of the algorithm, remove the comment to activate the command: Console.WriteLine("Number entered correctly");
            // Calling a function (method)
            CalcThirdDigit(number);
        }
        catch
        {
            Console.WriteLine("Need to enter number or the entered number is too large");
        }
    }
}
