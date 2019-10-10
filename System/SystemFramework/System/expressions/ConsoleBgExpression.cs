using System;
using System.Collections.Generic;
using System.Text;
using wolvm;

namespace wolSystem.expressions
{
    public class ConsoleBgExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            try
            {
                Console.BackgroundColor = (ConsoleColor)((wolInt)args[0].type).value;
            }
            catch (Exception)
            {
                return new Value(new wolInt((int)Console.BackgroundColor));
            }
            return Value.VoidValue;
        }
    }
}
