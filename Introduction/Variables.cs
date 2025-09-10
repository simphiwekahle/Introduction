namespace Introduction;

public class Variables
{
    public static void Run()
    {
        // Variable is a container that holds a value
        int age = 28;
        string name = "Simphiwekahle";
        bool isStudent = false;
        char grade = 'S';
        
        float height = 5.6f; // 32bit
        double weight = 130.5; // 64bit

        const double Pi = 3.14159;

        Console.WriteLine("Name:\t" + name);
        Console.WriteLine("Age:\t" + age);

        // Formatted strings
        Console.WriteLine("Name: {0}, Age: {1}", name, age);

        // String interpolation
        Console.WriteLine($"Name: {name}");
    }
}
