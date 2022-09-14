internal class Program
{
    private static void Main(string[] args)
    {
        // Specify a one-dimensional array filled with random numbers. Find the sum of elements in odd positions.
        // [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Function (method) that defines an array of N elements.
        int[] GetArrayRandom(int size, int startValue, int endValue)
        {
            // Creating an empty array of N elements.
            var array = new int[size];

            // Enter a variable into which random numbers will be generated.
            var random = new Random();

            // Definition of input number.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(startValue, endValue + 1);
            }
            return array;
        }

        // Function (method) that displays an array.
        string GetArrayOutput(int[] array)
        {
            string result = "[";
            for (int i = 0; i < array.Length; i++)
            {
                result = result + array[i];

                // Adding a comma after a number.
                if (i < array.Length - 1)
                {
                    result = result + ", ";
                }
            }
            result = result + "]";
            return result;
        }

        // A function for calculating the sum of elements in odd positions.
        int GetSumOddPositions(int[] array)
        {
            int i = 1;
            int sum = 0;
            while (i < array.Length)
            {
                sum = sum + array[i];
                i = i + 2;
            }
            return sum;
        }

        // Ask the user for the size of the array.
        Console.Write("Enter the size of the array: ");
        int sizeArray = Convert.ToInt32(Console.ReadLine());

        // Calling a function (method) and returning the result to a variable.
        var array = GetArrayRandom(sizeArray, -999, 999);
        var sumOddPositions = GetSumOddPositions(array);

        // Displaying the result on the screen.
        Console.WriteLine($"Array entered by the user: {GetArrayOutput(array)}");
        Console.WriteLine($"The sum of elements in odd positions is equal to {sumOddPositions}");
    }
}
