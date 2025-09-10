namespace Introduction;

public class BasicDisplay
{
    public static void Run()
    {
        Console.WriteLine("Hello World");

        Console.Write("What does this do?");
        Console.WriteLine("Compared to this??");

        // \t, \n, \\, \
        Console.WriteLine("This is the first line.\nThis is the second line."); // '\n' ~ goes to the next line
        Console.WriteLine("Column1\tColumn2\tColumn3"); // '\t' ~ this creates a tab space

        Console.WriteLine("C:\\Images"); // return a single back slash
        Console.WriteLine("Sphe said: \"Hi\"");
    }
}
