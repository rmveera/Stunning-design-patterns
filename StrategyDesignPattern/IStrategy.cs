using System;

namespace StrategyDesignPattern
{
    public class Client
    {
        public IStrategy Strategy { get; set; }

        public void CallAlgorithm()
        {
            Console.WriteLine(Strategy.Algorithm());
        }
    }

    public interface IStrategy
    {
        string Algorithm();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public string Algorithm()
        {
            return "Concrete Strategy A";
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public string Algorithm()
        {
            return "Concrete Strategy B";
        }
    }
}