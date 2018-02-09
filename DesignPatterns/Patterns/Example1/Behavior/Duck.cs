using System;

namespace DesignPatterns.Patterns.Example1.Behavior
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        public abstract string Dispay();

        public string PerformFly()
        {
            return FlyBehavior.Fly();
        }

        public string PerformQuack()
        {
            return QuackBehavior.Quack();
        }

        public virtual string Swim()
        {
            return "Умеет плавать";
        }
    }
}
