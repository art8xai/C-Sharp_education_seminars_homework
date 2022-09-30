internal class Program
{
    private static void Main(string[] args)
    {
        // Specify a two-dimensional m×n array filled with random real numbers.

        // m = 3, n = 4
        // 0,5 7 -2 -0,2
        // 1 -3,3 8 -9,9
        // 8 7,8 -7,1 9

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Function (method) to create an array filled with random real numbers.
        double[,] GetArrayRandomRealNumbers(int m, int n, int startValue, int endValue, int roundValue)
        {
            double[,] array = new double[m, n];

            // Setting the variable into which random numbers will be generated.
            var random = new Random();

            // Loop to move through rows.
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Loop to move through columns.
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // Generate a random number by adding an integer and a double, then rounding to one decimal place.
                    array[i, j] = Math.Round(random.Next(startValue, endValue) + random.NextDouble(), roundValue);
                }
            }
            return array;
        }

        // Function (method) that outputs an array to the console.
        void GetArrayRealPrint(double[,] array)
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

        // Calling a function (method), returning the result to a variable and displaying the result on the screen.
        var array = GetArrayRandomRealNumbers(m, n, -9, 10, 1);
        GetArrayRealPrint(array);
    }
}
