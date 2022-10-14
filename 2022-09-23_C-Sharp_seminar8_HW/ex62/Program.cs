internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that fills a 4 by 4 array helix.
        // For example, the output is the following array:
        // 01 02 03 04
        // 12 13 14 05
        // 11 16 15 06
        // 10 09 08 07

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // A function (method) that sorts the elements of each row of a two-dimensional array in descending order.
        void GetSpiralFillArray(int m, int n)
        {
            int[,] array = new int[m, n];

            // Enumerate numbers from 1 to the number of array elements.
            int number = 1;

            int i = 0;
            int j = 0;
            int square = 0;

            while (number <= array.GetLength(0) * array.GetLength(1))
            {
                array[i, j] = number;
                if ((i == square) && (j < array.GetLength(1) - square - 1))
                {
                    j++;
                }
                else if ((j == array.GetLength(1) - square - 1) && (i < array.GetLength(0) - square - 1))
                {
                    i++;
                }
                else if ((i == array.GetLength(0) - square - 1) && (j > square))
                {
                    j--;
                }
                else i--;

                if ((i == square + 1) && (j == square) && (square != array.GetLength(1) - square - 1))
                {
                    square++;
                }
                number++;
            }

            // Output an array to the console.
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    // Adding the digit 0 to the output of the array if the number is less than 10.
                    if (array[i, j] < 10)
                    {
                        Console.Write("0");
                    }
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        // According to the conditions of the problem, it is necessary to display a 4x4 array, assign these values ​​to variables.
        // Array dimension (number of rows).
        int m = 4;
        // Array dimension (number of columns).
        int n = 4;

        // Calling a function (method) and displaying the result on the screen.
        Console.WriteLine("An array filled with a spiral from 1 to the total number of elements in the array:");
        GetSpiralFillArray(m, n);

        // Keep the console window open in debug mode.
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
