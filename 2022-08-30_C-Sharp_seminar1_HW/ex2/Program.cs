internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes two numbers as input and outputs which number is greater and which is less

        // Definition of input numbers
        Console.Write("Enter a first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        // Compare of input numbers
        if (firstNumber == secondNumber)
        {
            Console.WriteLine("The numbers are equal");
        }
        else
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"min = {secondNumber}, max = {firstNumber}");
            }
            else
            {
                Console.WriteLine($"min = {firstNumber}, max = {secondNumber}");
            }
        }

    }
}
