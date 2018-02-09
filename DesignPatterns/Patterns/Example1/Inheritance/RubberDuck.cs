using System;

namespace DesignPatterns.Patterns.Example1.Inheritance
{
    /// <summary>
    /// Резиновая утка.
    /// </summary>
    public class RubberDuck : Duck
    {
        public override string Dispay()
        {
            return "Резиновая утка";
        }

        public override string Fly()
        {
            return "-";
        }

        public override string Quack()
        {
            return "Пик-пик";
        }
    }
}
