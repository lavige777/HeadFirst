using System;

namespace DesignPatterns.Patterns.Example1.Interface
{
    public class MallardDuck : Duck, IQuackable, IFlyable
    {
        public override string Dispay()
        {
            return "Малдарская утка";
        }

        public string Fly()
        {
            return "Умеет летать";
        }

        public string Quack()
        {
            return "Кря-кря";
        }
    }
}
