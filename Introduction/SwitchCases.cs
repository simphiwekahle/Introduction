namespace Introduction;

public class SwitchCases
{
    public static void Run()
    {
        // Traditional switch case
        char grade = 'A';
        int age = 18;

        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent");
                break;
            case 'B':
                Console.WriteLine("Good Job");
                break;
            default:
                Console.WriteLine("Keep trying");
                break;
        }

        Console.WriteLine("\n");

        // Modern syntax
        string result = grade switch
        {
            'A' => "Excellent",
            'B' => "Good Job",
            _ => "Keep Trying"
        };
        Console.WriteLine($"Grade is {result}");

        Console.WriteLine("\n");

        // Ternary operator syntax
        int a = 10, b = 20;

        int max = (a > b) ? a : b;
        Console.WriteLine($"Max is {max}");

        Console.WriteLine("\n");
    }
}
