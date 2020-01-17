using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using wolSystem.classes;
using wolvm;

namespace wolSystem.expressions
{
    public class OpenStreamWriterExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args) => new Value(new wolStreamWriter(new StreamWriter(((wolString)args[0].type).value)));
    }
}
