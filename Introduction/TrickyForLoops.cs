namespace Introduction;

public class TrickyForLoops
{
    public static void Run()
    {
        Console.WriteLine("Calculate the average of 5 marks");

        double total = 0;
        Console.WriteLine("Enter your marks");

        for (int subject = 1; subject <= 5; subject++)
        {
            Console.WriteLine($"Subject {subject} is ");
            double mark = double.Parse(Console.ReadLine());

            total += mark;
        }

        Console.WriteLine("Your average mark is " + (total / 5));
    }

    public static void FinalMark()
    {
        Console.WriteLine("Calculating the final mark");

        string? name;
        double test = 0, exam = 0, finalMark = 0;

        for (int subject = 1; subject <=3; subject++)
        {
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your test mark:");
            test = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your exam mark:");
            exam = double.Parse(Console.ReadLine());

            test = (test/100) * 40;
            exam = (exam/100) * 60;

            finalMark = test + exam;
            //var average =

            Console.WriteLine($"{name}'s final mark is {finalMark}");
            Console.WriteLine("\n");
        }

        //Console.WriteLine("Your average mark is " + (total / 5));
    }
}
