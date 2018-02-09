using System;

namespace DesignPatterns.Patterns.Example1.Behavior
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWingsBehavior();
            QuackBehavior = new QuackBehavior();
        }

        public override string Dispay()
        {
            return "Малдарская утка";
        }
    }
}
