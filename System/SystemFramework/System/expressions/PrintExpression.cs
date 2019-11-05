using System;
using wolvm;

namespace wolSystem.expressions
{
    public class PrintExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            foreach (Value arg in args)
            {
                try
                {
                    Console.Write(((wolString)arg.type).value);
                }
                catch (InvalidCastException)
                {
                    Console.Write(arg.type.ToString());
                }
            }
            return Value.VoidValue;
        }
    }
}
