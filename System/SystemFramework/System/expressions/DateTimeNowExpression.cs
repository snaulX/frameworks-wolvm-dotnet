using System;
using System.Collections.Generic;
using System.Text;
using wolSystem.classes;
using wolvm;

namespace wolSystem.expressions
{
    public class DateTimeNowExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            return new Value(new wolDateTime(DateTime.Now));
        }
    }
}
