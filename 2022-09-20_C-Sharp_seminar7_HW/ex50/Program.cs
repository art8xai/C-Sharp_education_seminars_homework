internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes the position of an element in a two-dimensional array as input
        // and returns the value of that element or an indication that there is no such element.

        // For example, given an array:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 1, 7 -> there is no such number in the array

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

        // Calling a function (method) and returning the result to a variable.
        var array = GetArrayRandomIntegerNumbers(new Random().Next(1, 10), new Random().Next(1, 10), new Random().Next(-9, 0), new Random().Next(0, 10));

        // The row position of the element to be searched for in the two-dimensional array.
        int m = 0;

        // The column position of the element to be searched for in the two-dimensional array.
        int n = 0;

        // User input position of the element (m and n).
        Console.Write("Enter the row corresponding to the position of the searched element in the two-dimensional array (M): ");
        bool parseIsOk = int.TryParse(Console.ReadLine(), out int number);
        if (!parseIsOk)
        {
            Console.Write("Invalid format value entered");
            return;
        }
        else if (number < 0)
        {
            Console.Write("Please enter a non-negative number");
            return;
        }
        else m = number;

        Console.Write("Enter the column corresponding to the position of the searched element in the two-dimensional array (N): ");
        parseIsOk = int.TryParse(Console.ReadLine(), out number);
        if (!parseIsOk)
        {
            Console.Write("Invalid format value entered");
            return;
        }
        else if (number < 0)
        {
            Console.Write("Please enter a non-negative number");
            return;
        }
        else n = number;

        try
        {
            int result = array[m, n];
            Console.WriteLine($"{m}, {n} -> {result}");
        }
        catch
        {
            Console.WriteLine($"{m}, {n} -> there is no such number in the array");
        }

        // Display a randomly given array on the screen.
        Console.WriteLine("Press Enter, Space or any key to display the random array in which an attempt was made to find a value...");
        Console.ReadKey();
        GetArrayIntegerPrint(array);
    }
}
