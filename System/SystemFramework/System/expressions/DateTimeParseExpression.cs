using System;
using System.Collections.Generic;
using System.Text;
using wolSystem.classes;
using wolvm;

namespace wolSystem.expressions
{
    public class DateTimeParseExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            return new Value(new wolDateTime(DateTime.Parse(args[0].type.ToString())));
        }
    }
}
