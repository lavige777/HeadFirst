using System;

namespace DesignPatterns.Patterns.Example1.Behavior
{
    /// <summary>
    /// Резиновая утка.
    /// </summary>
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWayBehavior();
            QuackBehavior = new SqueakBehavior();
        }

        public override string Dispay()
        {
            return "Резиновая утка";
        }
    }
}
