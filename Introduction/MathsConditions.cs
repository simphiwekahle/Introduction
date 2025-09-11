namespace Introduction;

public class MathsConditions
{
    public static void Run()
    {
        double radius;
        double height;
        double givenPaint = 1000; // in square units

        Console.Write("Radius value:\t");
        radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n");
        Console.Write("Height value:\t");
        height = Convert.ToDouble(Console.ReadLine());

        double surfaceArea = (Math.PI * Math.Pow(radius, 2)) + (Math.PI * radius * Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2)));

        Console.WriteLine($"The surface area is {surfaceArea}");

        if (surfaceArea > givenPaint)
        {
            Console.WriteLine("You do not have enough paint."); 
            Console.WriteLine();
            Console.WriteLine("Remaining paint needed is " + (surfaceArea - givenPaint));
        }
        else
        {
            Console.WriteLine("You have enough paint.");
        }
    }

}
