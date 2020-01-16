using System;
using System.Collections.Generic;
using System.Text;
using wolvm;
using wolSystem.classes;

namespace wolSystem.expressions
{
    public class ReadToEndExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args) => new Value(new wolString(((wolStreamReader)args[0].type).value.ReadToEnd()));
    }
}
