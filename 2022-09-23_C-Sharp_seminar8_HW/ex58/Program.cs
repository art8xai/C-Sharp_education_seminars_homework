internal class Program
{
    private static void Main(string[] args)
    {
        // Define two matrices. Write a program that will find the product of two matrices.

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

        // A function (method) that will calculate the multiplication of two matrices.
        int[,] GetArrayMultiplicationTwoMatriх(int[,] matrix1, int[,] matrix2)
        {
            // Creating an array in which we will place the result of calculations.
            int[,] resultArray = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            // For more information about matrix multiplication, see the link https://en.wikipedia.org/wiki/Matrix_multiplication.
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    resultArray[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        resultArray[i, j] = resultArray[i, j] + matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return resultArray;
        }

        // Dimension of the first matrix (number of rows).
        int m1 = 0;

        // Dimension of the first matrix (number of columns).
        int n1 = 0;

        // User input size (m by n) of the first matrix.
        Console.Write("Enter number of rows (M1) of the first matrix: ");
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
        else m1 = number;

        Console.Write("Enter number of columns (N1) of the first matrix: ");
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
        else n1 = number;

        Console.WriteLine();

        // Dimension of the second matrix (number of rows).
        int m2 = 0;

        // Dimension of the second matrix (number of columns).
        int n2 = 0;

        // User input size (m by n) of the first matrix.
        Console.Write("Enter number of rows (M2) of the second matrix: ");
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
        else m2 = number;

        Console.Write("Enter number of columns (N2) of the second matrix: ");
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
        else n2 = number;

        Console.WriteLine();

        // Setting the range of numbers that will be used to generate the array matrix.
        int startValueArray = 0;
        int endValueArray = 0;

        Console.WriteLine("Enter a range of numbers in the matrix...");
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
        // For the first matrix.
        var matrix1 = GetArrayRandomIntegerNumbers(m1, n1, startValueArray, endValueArray);
        Console.WriteLine();
        Console.WriteLine("First generated matrix:");
        GetArrayIntegerPrint(matrix1);
        // For the second matrix.
        var matrix2 = GetArrayRandomIntegerNumbers(m2, n2, startValueArray, endValueArray);
        Console.WriteLine();
        Console.WriteLine("Second generated matrix:");
        GetArrayIntegerPrint(matrix2);

        Console.WriteLine();
        // Multiplication of two matrices is possible only if the number of columns of the first (N1) is equal to the number of rows of the second (M2).
        if (n1 != m2)
        {
            Console.WriteLine("Multiplication of two matrices is impossible, because the number of columns of the first matrix"
            + " is not equal to the number of rows of the second matrix.");
        }
        else
        {
            // Calling a function (method), returning the result to a variable, and displaying the result on the screen.
            var arrayMultiplicationTwoMatriх = GetArrayMultiplicationTwoMatriх(matrix1, matrix2);
            Console.WriteLine("The result of multiplying two matrices:");
            GetArrayIntegerPrint(arrayMultiplicationTwoMatriх);
        }

        // Keep the console window open in debug mode.
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
