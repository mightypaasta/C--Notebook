using ConsoleApp1.src.Coffeeshop.Interfaces;
namespace ConsoleApp1.src.Coffeeshop.BaseComponents;

public class Espresso : IBeverage
{
    public string Name { get; } = "Espresso";

    public double Cost { get; } = 1.99;

    public string Description { get; } = "Espresso is a concentrated form of coffee served in small, strong shots and is the base for many coffee drinks.";

    public double GetCost()
    {
        return Cost;
    }

    public string GetDescription()
    {
        return Description;
    }
    
}