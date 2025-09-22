namespace Introduction;

public class MovieTicketConditions
{
    public static void Run()
    {
        double basePrice = 12.00, calculatedPrice, finalPrice;

        Console.WriteLine("Please enter your category: (Options are Student, Senior ,Child or Weekend)");
        string? category = Console.ReadLine();

         if (category is "Student")
        {
            Console.WriteLine("Do you have a student id? (Yes/No)");
            string? hasId = Console.ReadLine();

            Console.WriteLine($"Category is {category} and has student Id? {hasId}");

            calculatedPrice = hasId switch
            {
                "Yes" => basePrice * (1 - 0.12),
                _ => basePrice
            };

            finalPrice = (hasId == "Yes") ? calculatedPrice : basePrice;

            Console.WriteLine($"The final Price is {finalPrice:C}");
        }
        else
        {
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Category is {category} and age {age} ");

            switch (category)
            {
                case "Child":
                    finalPrice = (age < 12) ? 8 : basePrice;
                    Console.WriteLine($"The final Price is {finalPrice:C}");
                    break;

                case "Senior":
                    finalPrice = (age >= 12) ? 7 : basePrice;
                    Console.WriteLine($"The final Price is {finalPrice:C}");
                    break;

                case "Weekend":
                    finalPrice = basePrice + 2;
                    Console.WriteLine($"The final Price is {finalPrice:C}");
                    break;

                default:
                    finalPrice = basePrice;
                    Console.WriteLine($"The final Price is {finalPrice:C}");
                    break;
            }
        }
    }
}
