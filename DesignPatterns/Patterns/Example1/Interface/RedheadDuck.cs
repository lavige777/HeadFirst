using System;

namespace DesignPatterns.Patterns.Example1.Interface
{
    /// <summary>
    /// Красноголовая утка.
    /// </summary>
    public class RedheadDuck : Duck, IQuackable, IFlyable
    {
        public override string Dispay()
        {
            return "Красноголовая утка";
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
