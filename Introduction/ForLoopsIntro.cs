namespace Introduction;

public class ForLoopsIntro
{
    public static void Run()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Hi");
            Console.WriteLine(i);
        }

        Console.WriteLine("\n");

        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n");

        for (int i = 0; i <= 10; i += 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n");
        Console.WriteLine("Return Even and Odd numbers from 1 to 20");

        for (int i = 1; i <= 20; i++)
        {
            if ((i % 2) is not 0)
            {
                Console.WriteLine(i + " is an odd number.");
            }
            else
            {
                Console.WriteLine(i + " is an even number");
            }
        }

        Console.WriteLine("\n");
        Console.WriteLine("Multiples of 6");

        for (int i = 1; i <= 100; i++)
        {
            if ((i % 6) is 0)
            {
                Console.WriteLine(i + " is a multiple of 6");
            }
        }

        Console.WriteLine("\n");
        Console.WriteLine("Guessing Game");

        Random number = new();
        int randomValue = number.Next(1, 101);

        for (int i = 20; i > 0; i--)
        {
            Console.WriteLine("Guess an number between 1 - 100");
            Console.WriteLine($"Attempts left: {i}");
            int myGuess = int.Parse(Console.ReadLine());

            if (randomValue == myGuess)
            {
                Console.WriteLine("Your guess is correct");
                break;
            }
            else if ((randomValue > myGuess) && (myGuess is not 10111))
            {
                Console.WriteLine($"Your guess is Lower");
            }
            else if ((randomValue < myGuess) && (myGuess is not 10111))
            {
                Console.WriteLine($"Your guess is High");
            }
            else if (myGuess is 10111)
            {
                Console.WriteLine($"The random value is {randomValue}");
            }
        }
    }
}
