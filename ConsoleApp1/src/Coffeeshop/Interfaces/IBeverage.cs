namespace ConsoleApp1.src.Coffeeshop.Interfaces;
public interface IBeverage
{
    string Name { get; }
    double Cost { get; }
    string Description { get; }
    string GetDescription();
    double GetCost();
}
