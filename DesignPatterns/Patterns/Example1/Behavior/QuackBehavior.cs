using System;

namespace DesignPatterns.Patterns.Example1.Behavior
{
    public class QuackBehavior : IQuackBehavior
    {
        public string Quack()
        {
            return "Кря-кря";
        }
    }
}
