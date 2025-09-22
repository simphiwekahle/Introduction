namespace Introduction;

public class WhileLoops
{
    public static void Run()
    {
        //int i = 0;
        //while (i < 5)
        //{
        //    string? name = Console.ReadLine();
        //    Console.Write($"Name {i + 1} is: {name}");
        //    Console.WriteLine("\n");

        //    i++;
        //}

        //Console.WriteLine("\n");

        //string? myName = "";
        //List<string?> names = [];

        //while (myName is not "Stop")
        //{
        //    myName = Console.ReadLine();

        //    names.Add(myName);
        //}

        //string allNames = string.Join(", ", names);

        //Console.WriteLine($"Hi {allNames}");

        Console.WriteLine("\n");
        Console.WriteLine("Fighting Game");

        int playerHealth = 100, countDown = 3, numberOfHits = 0;

        Random number = new();

        Console.WriteLine($"Challenger has {playerHealth}% health!");

        for (int i = countDown; i > 0; i--)
        {
            Console.WriteLine($"Challenger coming in {i}");
            Task.Delay(2000).Wait();
        }

        Console.WriteLine("BEGIN FIGHT");

        while (playerHealth > 0)
        {
            int hitCount = number.Next(5, 15);
            numberOfHits++;
             
            Console.WriteLine($"Enemy hit by {hitCount}");
            playerHealth -= hitCount;

            if (playerHealth < 0)
            {
                break;
            }

            Console.WriteLine($"Remaining enemy health {playerHealth}");

            Task.Delay(2000).Wait();
        }

        Console.WriteLine("You Win!");

        if (numberOfHits < 10)
        {
            Console.WriteLine("YOU ARE A MASTER");
        }
        else 
        {
            Console.WriteLine("GO HIT THE GYM🤸💪");
        }
    }
}
