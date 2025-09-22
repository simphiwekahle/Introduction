namespace Introduction;

public class CoffeeShop
{
    public static void Run()
    {
        Random number = new Random();
        int randomNumber = number.Next(1, 4);
        string? message;
        double cost;

        Console.Write($"And the random number is... {randomNumber}\n");

        //cost = randomNumber switch
        //{
        //    1 => 0,
        //    2 => 5 * 0.9,
        //    _ => 7
        //};

        //message = randomNumber switch
        //{
        //    1 => "You won a free coffee!",
        //    2 => $"You get a 10% discount! Final price after discount: {cost:C}",
        //    _ => $"Better luck next time, Your cost is: {cost:C}",
        //};

        switch (randomNumber)
        {
            case 1:
                message = "You won a free coffee!";
                break;
            case 2:
                cost = 5 * 0.9;
                message = $"You get a 10% discount! Final price after discount: {cost:C}";
                break;
            default:
                cost = 7;
                message = $"Better luck next time, Your cost is: {cost:C}";
                break;
        }

        Console.WriteLine(message);
    }
}
