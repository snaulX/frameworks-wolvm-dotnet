using System;
using System.Collections.Generic;
using System.Text;
using wolvm;

namespace wolSystem.expressions
{
    public class ConsoleTitleExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            try
            {
                Console.Title = ((wolString)args[0].type).value;
            }
            catch (Exception)
            {
                return new Value(new wolString(Console.Title));
            }
            return Value.VoidValue;
        }
    }
}
