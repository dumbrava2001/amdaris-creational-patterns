using AssignmentCreationalDP.Builders;
using AssignmentCreationalDP.Models;

namespace AssignmentCreationalDP;

internal static class Program
{
    public static void Main(string[] args)
    {
        CreateEspressoCoffee();

        CreateCappuccinoCoffee();

        CreateFlatWhiteCoffee();
    }

    private static void CreateEspressoCoffee()
    {
        CoffeeBuilder coffeeBuilder = new EspressoCoffeeBuilder();
        coffeeBuilder.AddMilk(new OatMilk(3.5));
        coffeeBuilder.AddSugar(new Sugar("Brown Sugar"));

        var customEspressoCoffee = coffeeBuilder.GetCoffee();
        Console.WriteLine("Creating customized espressoCoffee with oat milk and brown sugar");
        Console.WriteLine(customEspressoCoffee.ToString());
    }

    private static void CreateCappuccinoCoffee()
    {
        CoffeeBuilder cappuccinoBuilder = new CappuccinoCoffeeBuilder();
        cappuccinoBuilder.AddMilk(new SoyMilk(3.0));
        cappuccinoBuilder.AddMilk(new OatMilk(2.0));
        cappuccinoBuilder.AddSugar(new Sugar("White Sugar"));
        cappuccinoBuilder.AddSugar(new Sugar("White Sugar"));
        cappuccinoBuilder.AddSugar(new Sugar("White Sugar"));

        var customCappuccino = cappuccinoBuilder.GetCoffee();
        Console.WriteLine("Creating cappuccino with extra milk and sugar");
        Console.WriteLine(customCappuccino.ToString());
    }

    private static void CreateFlatWhiteCoffee()
    {
        CoffeeBuilder flatWhiteBuilder = new FlatWhiteCoffeeBuilder();
        flatWhiteBuilder.AddSugar(new Sugar("Brown Sugar"));

        var customFlatWhiteCoffee = flatWhiteBuilder.GetCoffee();
        Console.WriteLine("Creating flat white coffee with brown sugar");
        Console.WriteLine(customFlatWhiteCoffee.ToString());
    }
}