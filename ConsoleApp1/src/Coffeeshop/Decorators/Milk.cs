namespace ConsoleApp1.src.Coffeeshop.Decorators
{
    using ConsoleApp1.src.Coffeeshop.Interfaces;

    public class WithMilk : CondimentDecorator
    {
        public WithMilk(IBeverage beverage) : base(beverage)
        {
        }

        public override double GetCost()
        {
            return _beverage.GetCost() + 0.50;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + "with Milk";
        }
    }
}