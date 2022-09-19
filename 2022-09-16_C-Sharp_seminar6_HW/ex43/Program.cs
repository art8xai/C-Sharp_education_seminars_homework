internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that will find the point of intersection of two lines given by the equations
        // y = k1 * x + b1, y = k2 * x + b2; the values ​​b1, k1, b2 and k2 are set by the user.
        // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // Function (method) for determining the coordinates of the point of intersection of two lines.
        double[] GetIntersectionPoint(double b1, double k1, double b2, double k2)
        {
            // Creating an empty array of 2 elements, which will store the coordinates of the point of intersection of two lines.
            var array = new double[2];
            // See more about line–line intersection https://en.wikipedia.org/wiki/Line%E2%80%93line_intersection.
            // The x and y coordinates of the point of intersection of two non-vertical lines can easily be found using the following substitutions and rearrangements.
            // Suppose that two lines have the equations y = k1 * x + b1 and y = k2 * x + b2 where k1 and k2 are the slopes (gradients) of the lines and where b1 and b2 are the y-intercepts of the lines.
            // At the point where the two lines intersect (if they do), both y coordinates will be the same, hence the following equality:
            // k1 * x + b1 = k2 * x + b2
            // We can rearrange this expression in order to extract the value of x,
            // k1 * x - k2 * x = b2 - b1
            // and so,
            // x = (b2 - b1) / (k1 - k2)
            double x = (b2 - b1) / (k1 - k2);

            // To find the y coordinate, all we need to do is substitute the value of x into either one of the two line equations, for example, into the first:
            double y = k1 * x + b1;

            // Round to two decimal places.
            array[0] = Math.Round(x, 2);
            array[1] = Math.Round(y, 2);

            // Returning the result of calculations.
            return array;
        }

        // Function (method) that outputs an equation as a string.
        string GetEquation(double b, double k)
        {
            string result = string.Empty;
            if (b != 0 && k != 0)
            {
                if (b < 0)
                {
                    if (k == -1)
                    {
                        result = $"y=-x{b}";
                    }
                    else if (k == 1)
                    {
                        result = $"y=x{b}";
                    }
                    else
                    {
                        result = $"y={k}x{b}";
                    }
                }
                else
                {
                    if (k == -1)
                    {
                        result = $"y=-x+{b}";
                    }
                    else if (k == 1)
                    {
                        result = $"y=x+{b}";
                    }
                    else
                    {
                        result = $"y={k}x+{b}";
                    }
                }
            }
            else
            {
                if (b == 0 && k == 0)
                {
                    result = "y=0";
                }
                if (b != 0 && k == 0)
                {
                    result = $"y={b}";
                }
                if (b == 0 && k != 0)
                {
                    if (k == -1)
                    {
                        result = $"y=-x";
                    }
                    else if (k == 1)
                    {
                        result = $"y=x";
                    }
                    else
                    {
                        result = $"y={k}x";
                    }
                }
            }
            return result;
        }

        try
        {
            // Definition of input numbers of the first equation.
            Console.Write("Input b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input k1: ");
            double k1 = Convert.ToDouble(Console.ReadLine());

            // Calling a function (method), returning the result to a variable and displaying the first equation on the screen.
            var firstEquation = GetEquation(b1, k1);
            Console.WriteLine($"First equation: {firstEquation}");

            // Definition of input numbers of the second equation.
            Console.Write("Input b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input k2: ");
            double k2 = Convert.ToDouble(Console.ReadLine());

            // Calling a function (method), returning the result to a variable and displaying the second equation on the screen.
            var secondEquation = GetEquation(b2, k2);
            Console.WriteLine($"Second equation: {secondEquation}");

            // Additional check of the number entered by the user.
            // If k1 = k2 then the two lines are parallel.
            if (k1 == k2)
            {
                Console.Write("The lines are parallel");
                // If b1 ≠ b2 as well, the lines are different and there is no intersection, otherwise the two lines are identical and intersect at every point.
                if (b1 != b2)
                {
                    Console.WriteLine(", different and have no intersection point.");
                }
                else
                    Console.WriteLine(", identical and intersect at every point.");
            }
            else
            {
                // Calling a function (method) and returning the result to a variable.
                var intersectionPoint = GetIntersectionPoint(b1, k1, b2, k2);

                // Displaying the result on the screen.
                Console.WriteLine($"The intersection point of the two lines given by the equations is the coordinate: " + "({0})", string.Join("; ", intersectionPoint));
            }
        }
        catch (Exception ex)
        {
            // Error message output.
            Console.WriteLine(ex.Message);
        }
    }
}
