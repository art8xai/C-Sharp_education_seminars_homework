internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes three numbers as input and outputs the maximum of these numbers

        // Definition of input numbers
        Console.Write("Enter a first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        // Introduced the variable "max" and conditionally preliminarily accept that the first input number is the maximum
         var max = firstNumber;

        // Compare of input numbers
        if (secondNumber > max)
        {
            max = secondNumber;
        }
        if (thirdNumber > max)
        {
            max = thirdNumber;
        }
        Console.WriteLine($"max = {max}");
    }
}
