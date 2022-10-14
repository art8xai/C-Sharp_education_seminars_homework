internal class Program
{
    private static void Main(string[] args)
    {
        // Form a three-dimensional array of non-repeating two-digit numbers.
        // Write a program that will print an array line by line, adding the indexes of each element.

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Function (method) for creating an array filled with non-repeating integer two-digit numbers.
        int[,,] GetArray3DUniqueTwoDigitNumbers(int m, int n, int p, int startValue, int endValue)
        {
            // A function (method) that checks whether the requested number is in the array.
            bool GetSearchElementArray3D(int[,,] array, int value)
            {
                // Loop to move through rows.
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    // Loop to move through columns.
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        // Loop to move through pages.
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            if (array[i, j, k] == value)
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }

            int[,,] array = new int[m, n, p];

            // Loop to move through rows.
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Loop to move through columns.
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // Loop to move through pages.
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        bool flag = false;
                        while (flag != true)
                        {
                            flag = false;
                            int temp = new Random().Next(startValue, endValue);
                            if (GetSearchElementArray3D(array, temp))
                            {
                                continue;
                            }
                            else array[i, j, k] = temp;
                            flag = true;
                        }
                    }
                }
            }
            return array;
        }

        // Function (method) that outputs an array to the console.
        void GetArray3DIntegerPrint(int[,,] array)
        {
            // Loop to move through rows.
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Loop to move through columns.
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // Loop to move through pages.
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i, j, k]}[{i}, {j}, {k}] ");
                    }
                    Console.WriteLine();
                }
                // Move to next line.
                Console.WriteLine();
            }
        }

        // Array dimension (number of rows).
        int m = 0;

        // Array dimension (number of columns).
        int n = 0;

        // Array dimension (number of pages).
        int p = 0;

        // User input of array size (m by n by p).
        Console.Write("Enter number of rows (M): ");
        bool parseIsOk = int.TryParse(Console.ReadLine(), out int number);
        if (!parseIsOk)
        {
            Console.Write("Invalid format value entered");
            return;
        }
        else if (number <= 0)
        {
            Console.Write("Please enter a positive number");
            return;
        }
        // The maximum number of two-digit numbers is 90, so we add an additional check.
        else if (number > 90)
        {
            Console.Write("Please enter a lower number because the array cannot be filled with non-repeating two-digit numbers");
            return;
        }
        else m = number;

        Console.Write("Enter number of columns (N): ");
        parseIsOk = int.TryParse(Console.ReadLine(), out number);
        if (!parseIsOk)
        {
            Console.Write("Invalid format value entered");
            return;
        }
        else if (number <= 0)
        {
            Console.Write("Please enter a positive number");
            return;
        }
        // The maximum number of two-digit numbers is 90, so we add an additional check.
        else if ((m * number) > 90)
        {
            Console.Write("Please enter a lower number because the array cannot be filled with non-repeating two-digit numbers");
            return;
        }
        else n = number;

        Console.Write("Enter number of pages (P): ");
        parseIsOk = int.TryParse(Console.ReadLine(), out number);
        if (!parseIsOk)
        {
            Console.Write("Invalid format value entered");
            return;
        }
        else if (number <= 0)
        {
            Console.Write("Please enter a positive number");
            return;
        }
        // The maximum number of two-digit numbers is 90, so we add an additional check.
        else if ((m * n * number) > 90)
        {
            Console.Write("Please enter a lower number because the array cannot be filled with non-repeating two-digit numbers");
            return;
        }
        else p = number;

        Console.WriteLine();

        // Setting the range of numbers that will be used to generate the array.
        // According to the conditions of the problem, two-digit numbers are required.
        int startValueArray = 10;
        int endValueArray = 100;

        // Calling a function (method), setting a digital range of numbers, returning the result to a variable and displaying the result on the screen.
        var array3D = GetArray3DUniqueTwoDigitNumbers(m, n, p, startValueArray, endValueArray);
        Console.WriteLine();
        Console.WriteLine($"Given an array of size {m} x {n} x {p}.");
        Console.WriteLine("The resulting three-dimensional array of non-repeating two-digit numbers:");
        GetArray3DIntegerPrint(array3D);

        // Keep the console window open in debug mode.
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
