internal class Program
{
    private static void Main(string[] args)
    {
        // The user enters M numbers from the keyboard. Count how many numbers greater than 0 the user entered.
        // 0, 7, 8, -2, -2 -> 2
        // -1, -7, 567, 89, 223-> 3

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Function (method) that defines an array of N elements.
        double[] GetArrayManually(int size)
        {
            // Creating an empty array of N elements.
            var array = new double[size];

            // Definition of input numbers.
            for (int i = 0; i < array.Length; i++)
            {
                // The terminal console is added inside the function (method) according to the task conditions.
                if (i == 0)
                {
                    if (array.Length > 1)
                    {
                        Console.Write("Enter the first number: ");
                    }
                    else
                    {
                        Console.Write("Enter the number: ");
                    }
                }
                else
                {
                    if (i < array.Length - 1)
                    {
                        Console.Write("Enter the next number: ");
                    }
                    else
                    {
                        Console.Write("Enter last number: ");
                    }
                }
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            return array;
        }

        // Function (method) for counting positive numbers in an array.
        int GetCountPositiveNumbers(double[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        try
        {
            // Ask the user for the size of the array.
            Console.Write("How many numbers do you want to enter: ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            // Additional check of the number entered by the user.
            if (sizeArray <= 0)
            {
                Console.Write("You need to enter a positive integer.");
            }
            else
            {
                // Calling a function (method) and returning the result to a variable.
                var array = GetArrayManually(sizeArray);
                var positiveNumbers = GetCountPositiveNumbers(array);

                // Displaying the result on the screen.
                Console.WriteLine("Array entered by the user: [{0}]", string.Join(", ", array));
                Console.WriteLine($"The count of numbers greater than 0 is {positiveNumbers}");
            }
        }
        catch (Exception ex)
        {
            // Error message output.
            Console.WriteLine(ex.Message);
        }
    }
}
