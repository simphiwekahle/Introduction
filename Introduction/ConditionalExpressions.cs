namespace Introduction;

public class ConditionalExpressions
{
    public static void Run()
    {
        string name1 = "Sphephelo";
        string name2 = "Simphiwekahle";

        int age1 = 15;
        int age2 = 28;

        const int legalAge = 18;

        if ((age1 is legalAge) && (age2 is legalAge))
        {
            Console.WriteLine($"{name1} and {name2} are both legal ages");
        }
        else if ((age1 is legalAge) || (age2 is legalAge))
        {
            Console.WriteLine($"{name1} or {name2} is a minors");
        }
        else
        {
            Console.WriteLine($"Neither {name1} nor {name2} is of legal age");
        }

        Console.WriteLine("\n");

        int number1 = 10;
        int number2 = 20;
        int number3 = 30;

        if ((number1 > number2) && (number1 > number3))
        {
            Console.WriteLine($"Number 1 {number1} is the greater number");
        }
        else if ((number2 > number1) && (number2 > number3))
        {
            Console.WriteLine($"Number 2 {number2} is the greater number");
        }
        else
        {
            Console.WriteLine($"Number 3 {number3} is the greater number");
        }

        Console.WriteLine("\n");

        double r = 10, h = 20, sa, givenArea = 500;

        sa = (2 * Math.PI * Math.Pow(r, 2)) + (2 * Math.PI * r * h);

        if (sa > givenArea)
        {
            Console.WriteLine("You do not have enough paint.");
            Console.WriteLine($"You need an additional {sa - givenArea} square units of paint.");
        }
        else
        {
            Console.WriteLine("You have enough paint.");
        }

    }
}
