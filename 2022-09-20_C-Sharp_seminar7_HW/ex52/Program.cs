internal class Program
{
    private static void Main(string[] args)
    {
        // Specify a two-dimensional array of integers. Find the arithmetic mean of the elements in each column.

        // For example, given an array:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // Arithmetic mean of each column: 4.6; 5.6; 3.6; 3.

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

        // The function (method) of finding the arithmetic mean of the elements in each column.
        double[] GetArrayColumnArithmeticMean(int[,] array, int roundValue)
        {
            // Creating a one-dimensional array in which we will place the result of calculations.
            double[] resultArray = new double[array.GetLength(1)];

            // Loop to move through columns.
            for (int i = 0; i < array.GetLength(1); i++)
            {
                // Loop to move through rows.
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    resultArray[i] = resultArray[i] + array[j, i];
                }
                // Rounding by discarding excess digits (according to the conditions of the problem according to the example).
                resultArray[i] = Math.Round(resultArray[i] / array.GetLength(0), roundValue, MidpointRounding.ToZero);
            }
            return resultArray;
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

        // Calling a function (method), setting a digital range of numbers, returning the result to a variable and displaying the result on the screen.
        var array = GetArrayRandomIntegerNumbers(m, n, -9, 10);
        GetArrayIntegerPrint(array);

        // Calling a function (method), setting rounding, returning the result to a variable, and displaying the result on the screen.
        var arrayColumnArithmeticMean = GetArrayColumnArithmeticMean(array, 1);
        Console.WriteLine($"Arithmetic mean of each array column: " + "{0}" + ".", string.Join("; ", arrayColumnArithmeticMean));
    }
}
