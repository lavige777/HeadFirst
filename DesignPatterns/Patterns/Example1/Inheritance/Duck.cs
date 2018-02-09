using System;

namespace DesignPatterns.Patterns.Example1.Inheritance
{
    public abstract class Duck
    {
        public abstract string Dispay();

        public virtual string Fly()
        {
            return "Умеет летать";
        }

        public virtual string Quack()
        {
            return "Кря-кря";
        }

        public virtual string Swim()
        {
            return "Умеет плавать";
        }
    }
}
