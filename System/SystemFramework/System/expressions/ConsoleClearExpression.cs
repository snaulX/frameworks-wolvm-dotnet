using System;
using System.Collections.Generic;
using System.Text;
using wolvm;

namespace wolSystem.expressions
{
    public class ConsoleClearExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            Console.Clear();
            return Value.VoidValue;
        }
    }
}
