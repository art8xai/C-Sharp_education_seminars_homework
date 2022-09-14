internal class Program
{
    private static void Main(string[] args)
    {
        // Find the product of pairs of numbers in a one-dimensional array.
        // We consider the first and last element, the second and penultimate, etc. as a pair. Write the result in a new array.
        // [1, 2, 3, 4, 5] -> [5, 8, 3]; [6, 7, 3, 6] -> [36, 21]


        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Function (method) that defines an array of N elements.
        int[] GetArrayManually(int size)
        {
            // Creating an empty array of N elements.
            int[] array = new int[size];

            // Definition of input number.
            for (int i = 0; i < array.Length; i++)
            {
                // The terminal console is added inside the function (method) according to the task conditions.
                Console.Write($"Enter a number to add to the array element[{i}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
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

        // Function (method) for calculating the product of pairs of numbers in a one-dimensional array.
        int[] GetСalcProductPairs(int[] array)
        {
            // Determining the size of a new array.
            int sizeNewArray = array.Length / 2;

            // If the original array is odd, increase the size of the new array by 1.
            if (array.Length % 2 != 0)
            {
                sizeNewArray = sizeNewArray + 1;
            }

            // Creating a new empty array.
            int[] newArray = new int[sizeNewArray];

            // Multiplying pairs of numbers and putting the result into a new array.
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i != array.Length - i - 1)
                {
                    newArray[i] = array[i] * array[array.Length - i - 1];
                }
                else
                {
                    newArray[i] = array[i];
                }
            }
            return newArray;
        }

        // Ask the user for the size of the array.
        Console.Write("Enter the size of the array: ");
        int sizeArray = Convert.ToInt32(Console.ReadLine());

        // Calling a function (method) and returning the result to a variable.
        var array = GetArrayManually(sizeArray);
        var newArray = GetСalcProductPairs(array);

        // Displaying the result on the screen.
        Console.WriteLine($"Array entered by the user: {GetArrayOutput(array)}");
        Console.WriteLine($"New array with products of pairs of numbers: {GetArrayOutput(newArray)}");
    }
}
