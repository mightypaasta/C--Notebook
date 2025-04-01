namespace ConsoleApp1.src.Coffeeshop.Decorators
{
    using ConsoleApp1.src.Coffeeshop.Interfaces;

    public class withMocha : CondimentDecorator
    {
        public withMocha(IBeverage beverage) : base(beverage)
        {
        }

        public override double GetCost()
        {
            return _beverage.GetCost() + 1.00;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + "with Mocha";
        }
    }
}