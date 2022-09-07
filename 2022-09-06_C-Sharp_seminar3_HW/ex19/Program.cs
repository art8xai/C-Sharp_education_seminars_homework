internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes a five-digit number as input and checks if it is a palindrome.
        // 14212 -> No
        // 12821 -> Yes
        // 23432 -> Yes

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Five-digit number palindrome check function (method).
        string GetCheckPalindrome(int x)
        {
            // Calculating the first two digits before the center digit.
            int before = x / 1000;
            // Calculate the last two digits after the center digit.
            int after = x % 100;
            // Introduce a new variable where the result will be placed.
            string result;
            // Determine if a number is a palindrome usштп conditional branching and using logical operator AND (symbol "&&").
            if ((before / 10 == after % 10) && (before % 10 == after / 10)) result = "Yes";
            else result = "No";
            return result;
        }

        // Checking the number entered by the user using the try...catch construct and start the calculations.
        try
        {
            // Definition of input number.
            Console.Write("Enter a five-digit positive number to check if it is a palindrome: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // To check the entered number (for five digits), use conditional branching and using logical operator OR (symbol "||").
            if ((number < 10000) || (number >= 100000)) Console.WriteLine("Invalid number entered");
            else
            {
                // To test the operation of the algorithm, remove the comment to activate the command: Console.WriteLine("Number entered correctly");
                // Calling a function (method) and returning the result to a variable.
                var palindrome = GetCheckPalindrome(number);
                // Displaying the result on the screen.
                Console.Write(palindrome);
            }
        }
        catch
        {
            Console.WriteLine("Need to enter integer number or the entered number is too large");
        }
    }
}
