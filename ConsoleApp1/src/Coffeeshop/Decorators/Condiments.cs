using ConsoleApp1.src.Coffeeshop.Interfaces;

namespace ConsoleApp1.src.Coffeeshop.Decorators;

public abstract class CondimentDecorator : IBeverage
{
    protected IBeverage _beverage;

    protected CondimentDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public string Name => _beverage.Name;

    public double Cost => _beverage.Cost;

    public string Description => _beverage.Description;

    public virtual double GetCost(){
        return _beverage.GetCost();
    }

    public virtual string GetDescription(){
        return _beverage.GetDescription();
    }
}