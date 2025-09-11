namespace Introduction;

public class Conditions
{
    public static void Run()
    {
        int a = 5;
        int b = 6;
        bool condition = false;

        if (a > b)
        {
            Console.WriteLine("a is greater than b");
        }
        else if (b > a)
        {
            Console.WriteLine("b is greater than a");
        }


        //int age = 20;
        //// if, else if, else
        //if (age < 18)
        //{
        //    Console.WriteLine("You are a minor.");
        //}
        //else if (age >= 18 && age < 65)
        //{
        //    Console.WriteLine("You are an adult.");
        //}
        //else
        //{
        //    Console.WriteLine("You are a senior citizen.");
        //}

        //// switch statement
        //string day = "Monday";
        //switch (day)
        //{
        //    case "Monday":
        //        Console.WriteLine("Start of the work week.");
        //        break;
        //    case "Wednesday":
        //        Console.WriteLine("Midweek day.");
        //        break;
        //    case "Friday":
        //        Console.WriteLine("End of the work week.");
        //        break;
        //    default:
        //        Console.WriteLine("Just another day.");
        //        break;
        //}
        //// Ternary operator
        //bool isMember = true;
        //double discount = isMember ? 0.1 : 0.0; // 10% discount for members
        //Console.WriteLine($"Discount: {discount * 100}%");
    }
}
