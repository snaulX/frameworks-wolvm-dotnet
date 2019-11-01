using System;
using System.Collections.Generic;
using System.Text;
using wolvm;

namespace wolSystem.expressions
{
    public class BeepExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            try
            {
                Console.Beep(((wolInt)args[0].type).value, ((wolInt)args[1].type).value);
            }
            catch (Exception)
            {
                Console.Beep();
            }
            return Value.VoidValue;
        }
    }
}
