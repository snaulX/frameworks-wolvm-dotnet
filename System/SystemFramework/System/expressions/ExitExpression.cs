using System;
using System.Collections.Generic;
using System.Text;
using wolvm;

namespace wolSystem.expressions
{
    public class ExitExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            Environment.Exit(((wolInt)args[0].type).value);
            return Value.VoidValue;
        }
    }
}
