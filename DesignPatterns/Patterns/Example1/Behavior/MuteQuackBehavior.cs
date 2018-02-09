using System;

namespace DesignPatterns.Patterns.Example1.Behavior
{
    public class MuteQuackBehavior : IQuackBehavior
    {
        public string Quack()
        {
            return "-";
        }
    }
}
