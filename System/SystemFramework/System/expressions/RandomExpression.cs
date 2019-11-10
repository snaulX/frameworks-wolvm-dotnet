using System;
using System.Collections.Generic;
using System.Text;
using wolvm;

namespace wolSystem.expressions
{
    public class RandomExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            switch (args.Length)
            {
                case 0:
                    return new Value(new wolDouble(new Random().NextDouble()));
                case 1:
                    return new Value(new wolInt(new Random().Next(((wolInt)args[0].type).value)));
                default:
                    VirtualMachine.ThrowVMException("Length of arguments more then need. Random", VirtualMachine.position, ExceptionType.ArgumentsOutOfRangeException);
                    return Value.VoidValue;
            }
        }
    }
}
