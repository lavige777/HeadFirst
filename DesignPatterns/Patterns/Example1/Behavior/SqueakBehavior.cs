using System;

namespace DesignPatterns.Patterns.Example1.Behavior
{
    public class SqueakBehavior : IQuackBehavior
    {
        public string Quack()
        {
            return "Пик-пик";
        }
    }
}
