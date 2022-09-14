internal class Program
{
    private static void Main(string[] args)
    {
        // Specify an array filled with random positive three-digit numbers. Write a program to show the number of even numbers in an array.
        // [345, 897, 568, 234] -> 2

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

        // A function (method) that counts the number of even numbers in an array.
        int GetEvenNumbers(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        // Ask the user for the size of the array.
        Console.Write("Enter the size of the array: ");
        int sizeArray = Convert.ToInt32(Console.ReadLine());

        // Calling a function (method) and returning the result to a variable.
        var array = GetArrayRandom(sizeArray, 100, 999);
        var evenNumbers = GetEvenNumbers(array);

        // Displaying the result on the screen.
        Console.WriteLine($"Array entered by the user: {GetArrayOutput(array)}");
        Console.WriteLine($"The number of even numbers in the array is {evenNumbers}");
    }
}
