using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using wolvm;
using wolSystem.classes;

namespace wolSystem.expressions
{
    public class CloseStreamWriterExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            StreamWriter stream = ((wolStreamWriter)args[0].type).value;
            stream.Dispose();
            stream.Close();
            return Value.VoidValue;
        }
    }
}
