namespace Introduction;

public class DragRace
{
    public static void Run()
    {
        int raceDistance = 500;
        Random distanceCovered = new();

        Console.WriteLine($"Begin Race in ");

        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine($"{i}");
            Task.Delay(500).Wait();
        }

        int bugattiDistance = 0;
        int ferarriDistance = 0;

        Random useNos = new();

        bool bugattiNos = useNos.Next(2) == 0;
        bool ferarriNos = useNos.Next(2) == 0;

        bool bugattiBoost = false;
        bool ferarriBoost = false;

        while (raceDistance > bugattiDistance || raceDistance > ferarriDistance)
        {
            int bugatti = distanceCovered.Next(30, 51);
            int ferarri = distanceCovered.Next(30, 51);

            bugattiDistance += bugatti;
            ferarriDistance += ferarri;

            if (bugattiNos && !ferarriNos && !bugattiBoost && !ferarriBoost)
            {
                bugattiBoost = true;

                bugattiDistance += 80;
                Console.WriteLine("Bugatti used NOS");
            }
            else if (ferarriNos && !bugattiNos && !bugattiBoost && !ferarriBoost)
            {
                ferarriBoost = true;

                ferarriDistance += 80;
                Console.WriteLine("Ferarri used NOS");
            }
            else if (bugattiNos && ferarriNos && !bugattiBoost && !ferarriBoost)
            {
                bugattiBoost = true;
                ferarriBoost = true;

                bugattiDistance += 80;
                ferarriDistance += 80;
                Console.WriteLine("Both racers are using NOS");
            }

            Task.Delay(500).Wait();
            Console.WriteLine("\n");

            if (bugattiDistance > ferarriDistance)
            {
                Console.WriteLine("Bugatti is now in front");
            }
            else if (ferarriDistance > bugattiDistance)
            {
                Console.WriteLine("Ferarri is now in front");
            }
            else
            {
                Console.WriteLine("The cars are head to head");
            }

            Console.WriteLine($"Bugatti is at {bugattiDistance}\tFerarri is at {ferarriDistance}");
            Console.WriteLine("\n");
            Task.Delay(500).Wait();
        }

        if (bugattiDistance > raceDistance)
        {
            Console.WriteLine("Bugatti Wins");
        }
        else if (ferarriDistance < raceDistance)
        {
            Console.WriteLine("Ferarri Wins");
        }

    }
}
