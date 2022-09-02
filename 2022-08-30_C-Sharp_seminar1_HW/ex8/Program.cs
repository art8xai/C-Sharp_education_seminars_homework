internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes a number (N) as input and outputs all even numbers from 1 to N

        // Definition of input number
        Console.Write("Enter a positive number to display all even numbers up to that number: ");
        int number = int.Parse(Console.ReadLine());

        // Checking if a positive number is entered
        if (number > 0)
        {
            // Determine all even numbers from 1 to N
            if (number >= 2)
            {
                // We enter the index (variable "i"), and take it equal to 2, because this is the first even number after one
                int i = 2;
                while (i <= number)
                {
                    Console.Write(i);
                    // Adding a comma after a number
                    if (i < number - 1)
                    {
                        Console.Write(", ");
                    }
                i = i + 2;
                }
            }
            else Console.WriteLine("No even numbers");
        }
        else Console.WriteLine("Invalid number entered");
    }
}
