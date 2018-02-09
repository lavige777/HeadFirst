using System;

namespace DesignPatterns.Patterns.Example1.Inheritance
{
    /// <summary>
    /// Деревянная утка-приманка.
    /// </summary>
    public class DecoyDuck : Duck
    {
        public override string Dispay()
        {
            return "Деревянная утка-приманка";
        }

        public override string Fly()
        {
            return "-";
        }

        public override string Quack()
        {
            return "-";
        }
    }
}
