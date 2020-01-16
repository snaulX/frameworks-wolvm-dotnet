using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using wolvm;
using wolSystem.classes;

namespace wolSystem.expressions
{
    public class CloseStreamReaderExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            StreamReader stream = ((wolStreamReader)args[0].type).value;
            stream.Dispose();
            stream.Close();
            return Value.VoidValue;
        }
    }
}
