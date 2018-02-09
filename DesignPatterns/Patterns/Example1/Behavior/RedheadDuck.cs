using System;

namespace DesignPatterns.Patterns.Example1.Behavior
{
    /// <summary>
    /// Красноголовая утка.
    /// </summary>
    public class RedheadDuck : Duck
    {
        public RedheadDuck() : base()
        {
            FlyBehavior = new FlyWithWingsBehavior();
            QuackBehavior = new QuackBehavior();
        }

        public override string Dispay()
        {
            return "Красноголовая утка";
        }
    }
}
