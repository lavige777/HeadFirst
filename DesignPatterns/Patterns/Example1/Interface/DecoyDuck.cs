using System;

namespace DesignPatterns.Patterns.Example1.Interface
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
    }
}
