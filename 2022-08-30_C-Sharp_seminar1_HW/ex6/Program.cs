internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes a number as input and outputs whether the number is even (is it divisible by two without a remainder)

        // Definition of input number
        Console.Write("Enter a number to see if it's even: ");
        int number = int.Parse(Console.ReadLine());

        // Determine if a number is divisible by two without a remainder
        if (number % 2 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
