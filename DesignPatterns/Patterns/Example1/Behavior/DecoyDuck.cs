using System;

namespace DesignPatterns.Patterns.Example1.Behavior
{
    /// <summary>
    /// Деревянная утка-приманка.
    /// </summary>
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior = new FlyNoWayBehavior();
            QuackBehavior = new MuteQuackBehavior();
        }

        public override string Dispay()
        {
            return "Деревянная утка-приманка";
        }
    }
}
