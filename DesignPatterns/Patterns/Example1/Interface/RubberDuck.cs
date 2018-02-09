using System;

namespace DesignPatterns.Patterns.Example1.Interface
{
    /// <summary>
    /// Резиновая утка.
    /// </summary>
    public class RubberDuck : Duck, IQuackable
    {
        public override string Dispay()
        {
            return "Резиновая утка";
        }

        public string Quack()
        {
            return "Пик-пик";
        }
    }
}
