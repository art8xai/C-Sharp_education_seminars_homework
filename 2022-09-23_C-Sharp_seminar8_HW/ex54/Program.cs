internal class Program
{
    private static void Main(string[] args)
    {
        // Specify a two-dimensional array. Write a program to sort in descending order the elements of each row of a two-dimensional array.

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Function (method) to create an array filled with random integer numbers.
        int[,] GetArrayRandomIntegerNumbers(int m, int n, int startValue, int endValue)
        {
            int[,] array = new int[m, n];

            // Setting the variable into which random numbers will be generated.
            var random = new Random();

            // Loop to move through rows.
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Loop to move through columns.
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(startValue, endValue);
                }
            }
            return array;
        }

        // Function (method) that outputs an array to the console.
        void GetArrayIntegerPrint(int[,] array)
        {
            // Loop to move through rows.
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Loop to move through columns.
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                // Move to next line.
                Console.WriteLine();
            }
        }

        // A function (method) that sorts the elements of each row of a two-dimensional array in descending order.
        void GetBubbleSortRowArray(int[,] array)
        {
            // Loop to move through rows.
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Loop to move through columns.
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // Using bubble sort array.
                    for (int k = 0; k < array.GetLength(1) - j - 1; k++)
                    {
                        if (array[i, k] < array[i, k + 1])
                        {
                            int temp = array[i, k];
                            array[i, k] = array[i, k + 1];
                            array[i, k + 1] = temp;
                        }
                    }
                }
            }
        }

        // Array dimension (number of rows).
        int m = 0;

        // Array dimension (number of columns).
        int n = 0;

        // User input of array size (m by n).
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
        else n = number;

        Console.WriteLine();

        // Setting the range of numbers that will be used to generate the array.
        int startValueArray = 0;
        int endValueArray = 0;

        Console.WriteLine("Enter a range of numbers in an array...");
        Console.Write("From: ");
        parseIsOk = int.TryParse(Console.ReadLine(), out number);
        if (!parseIsOk)
        {
            Console.Write("Invalid format value entered");
            return;
        }
        else startValueArray = number;

        Console.Write("To: ");
        parseIsOk = int.TryParse(Console.ReadLine(), out number);
        if (!parseIsOk)
        {
            Console.Write("Invalid format value entered");
            return;
        }
        else if (startValueArray >= number)
        {
            Console.Write("Please enter a number that is greater than the first number entered");
            return;
        }
        else endValueArray = number;

        // Calling a function (method), setting a digital range of numbers, returning the result to a variable and displaying the result on the screen.
        var array = GetArrayRandomIntegerNumbers(m, n, startValueArray, endValueArray);
        Console.WriteLine();
        Console.WriteLine("Source array:");
        GetArrayIntegerPrint(array);

        // Calling a function (method) and displaying the result on the screen.
        GetBubbleSortRowArray(array);
        Console.WriteLine();
        Console.WriteLine("The resulting sorted array of elements of each row (max -> min):");
        GetArrayIntegerPrint(array);

        // Keep the console window open in debug mode.
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
