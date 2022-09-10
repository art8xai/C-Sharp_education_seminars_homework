internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes an array of 8 elements and prints them to the screen. Array elements are entered by the user.
        // 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Function (method) that defines an array of N elements and displays them on the screen.
        int[] GetArray(int size)
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

        // A function (method) that displays an array on the screen.
        string GetPrintArray(int[] array)
        {
            // Displaying the result on the screen.
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

        // Calling a function (method) and returning the result to a variable.
        int[] arrayOf8Elements = GetArray(8);

        // Calling a function (method) and displaying the result on the screen.
        Console.WriteLine($"Array entered by the user: {GetPrintArray(arrayOf8Elements)}");
    }
}
