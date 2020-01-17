using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using wolSystem.classes;
using wolvm;

namespace wolSystem.expressions
{
    public class WriteFileExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            StreamWriter stream = ((wolStreamWriter)args[0].type).value;
            for (int i = 1; i < args.Length; i++)
            {
                Value arg = args[i];
                if (arg.type is wolString t) stream.Write(t.value);
                else stream.Write(arg.type.ToString());
            }
            return Value.VoidValue;
        }
    }
}
