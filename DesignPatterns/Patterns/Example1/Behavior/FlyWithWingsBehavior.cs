using System;

namespace DesignPatterns.Patterns.Example1.Behavior
{
    public class FlyWithWingsBehavior : IFlyBehavior
    {
        public string Fly()
        {
            return "Умеет летать";
        }
    }
}
