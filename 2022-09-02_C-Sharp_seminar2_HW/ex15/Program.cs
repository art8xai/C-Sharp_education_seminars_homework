internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes as input a number representing the day of the week and checks if that day is a holiday

        // Clear the console from the previous launch of the program
        Console.Clear();

        // Second digit search function (method)
        void WhatDayIs(int x)
        {
            if (x >= 6) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }

        // Definition of input number
        Console.Write("Enter a number representing the day of the week to find out if this day is a holiday: ");

        // Checking the number entered by the user and start the calculations
        // Using the try...catch construct
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            // Using logical operator OR (symbol "||")
            if (number < 1 || number > 7) Console.WriteLine("Invalid number entered");
            else
            {
                // To test the operation of the algorithm, remove the comment to activate the command: Console.WriteLine("Number entered correctly");
                // Calling a function (method)
                WhatDayIs(number);
            }
        }
        catch
        {
            Console.WriteLine("Need to enter number or the entered number is too large");
        }
    }
}
