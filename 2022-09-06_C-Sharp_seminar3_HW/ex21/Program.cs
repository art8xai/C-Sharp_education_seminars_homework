internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that takes the coordinates of two points as input and finds the distance between them in 3D space.
        // A (3,6,8); B (2,1,-7) -> 15.84
        // A (7,-5,0); B (1,-1,9) -> 11.53

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // The Euclidean distance is a geometric distance in multidimensional space. It is calculated by the calculation of Pythagoras.
        // See more https://en.wikipedia.org/wiki/Euclidean_distance

        // Function (method) to get coordinates.
        // The name of the entered coordinate is displayed for user convenience.
        int GetData(string nameCoordinate)
        {
            Console.Write($"Input {nameCoordinate}: ");
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }

        // 3D distance calculation function (method).
        double GetDistance3D(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
            return result;
        }

        // Checking the number entered by the user using the try...catch construct and start the calculations.
        try
        {
            // Definition of input coordinate numbers.
            Console.WriteLine("Enter point A coordinates");
            var x1 = GetData("X1");
            var y1 = GetData("Y1");
            var z1 = GetData("Z1");
            Console.WriteLine("Enter point B coordinates");
            var x2 = GetData("X2");
            var y2 = GetData("Y2");
            var z2 = GetData("Z2");
            
            // Calling a function (method) and returning the result to a variable.
            var distance3D = GetDistance3D(x1, y1, z1, x2, y2, z2);
            
            // Displaying the result on the screen rounded to two decimal places.
            Console.Write($"Distance in 3D space is {Math.Round(distance3D, 2)}");
        }
        catch
        {
            Console.WriteLine("Need to enter integer number or the entered number is too large");
        }
    }
}
