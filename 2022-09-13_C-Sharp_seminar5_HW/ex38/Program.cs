internal class Program
{
    private static void Main(string[] args)
    {
        // Specify an array of real numbers. Find the difference between the maximum and minimum elements of an array.
        // [3, 7, 22, 2, 78] -> 76

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Function (method) that defines an array of N elements.
        double[] GetArrayRandomRealNumbers(int size)
        {
            // Creating an empty array of N elements.
            var array = new double[size];

            // Enter a variable into which random numbers will be generated.
            var random = new Random();

            // Definition of input number.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble();
            }
            return array;
        }

        // Function (method) that displays an array.
        string GetArrayOutput(double[] array)
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

        // Function (method) to calculate the difference between the maximum and minimum array elements.
        double GetDifferenceMaxAndMinNumbers(double[] array)
        {
            int iMax = 0;
            int iMin = 0;
            double result = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[iMin])
                {
                    iMin = i;
                }
                else if (array[i] > array[iMax])
                {
                    iMax = i;
                }
            }
            result = array[iMax] - array[iMin];
            return result;
        }

        // Ask the user for the size of the array.
        Console.Write("Enter the size of the array: ");
        int sizeArray = Convert.ToInt32(Console.ReadLine());

        // Calling a function (method) and returning the result to a variable.
        var array = GetArrayRandomRealNumbers(sizeArray);
        var differenceMaxAndMinNumbers = GetDifferenceMaxAndMinNumbers(array);

        // Displaying the result on the screen.
        Console.WriteLine($"Array entered by the user: {GetArrayOutput(array)}");
        Console.WriteLine($"The difference between the maximum and minimum array elements is {differenceMaxAndMinNumbers}");
    }
}
