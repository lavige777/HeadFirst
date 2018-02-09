using System;

namespace DesignPatterns.Patterns.Example1.Interface
{
    public abstract class Duck
    {
        public abstract string Dispay();

        public virtual string Swim()
        {
            return "Умеет плавать";
        }
    }
}
