using System;

namespace DesignPatterns.Patterns.Example1.Behavior
{
    public class FlyNoWayBehavior : IFlyBehavior
    {
        public string Fly()
        {
            return "-";
        }
    }
}
