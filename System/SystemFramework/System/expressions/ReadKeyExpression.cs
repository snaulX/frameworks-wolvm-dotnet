using System;
using System.Collections.Generic;
using System.Text;
using wolvm;

namespace wolSystem.expressions
{
    public class ReadKeyExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            if (((wolBool)args[0].type).value)
                return new Value(new wolChar(Console.ReadKey().KeyChar));
            else
                return new Value(new wolInt((int)Console.ReadKey().Key));
        }
    }
}
