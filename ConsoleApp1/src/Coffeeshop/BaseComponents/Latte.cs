using ConsoleApp1.src.Coffeeshop.Interfaces;
namespace ConsoleApp1.src.Coffeeshop.BaseComponents;

public class Latte : IBeverage{
    public string Name { get; } = "Latte";
    public double Cost { get; } = 2.99;
    public string Description { get; } = "A latte is a coffee drink made with espresso and steamed milk.";
    public double GetCost(){
        return Cost;
    }
    public string GetDescription(){
        return Description;
    }
}