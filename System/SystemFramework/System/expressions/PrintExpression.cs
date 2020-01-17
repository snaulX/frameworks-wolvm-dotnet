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
                if (arg.type is wolString t) Console.Write(t.value);
                else Console.Write(arg.type.ToString());
            }
            return Value.VoidValue;
        }
    }
}
