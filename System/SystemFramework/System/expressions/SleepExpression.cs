using System;
using System.Threading;
using wolvm;

namespace wolSystem.expressions
{
    public class SleepExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            try
            {
                Thread.Sleep(((wolInt)args[0].type).value);
            }
            catch (InvalidCastException)
            {
                VirtualMachine.ThrowVMException("Argument haven`t type 'int'", VirtualMachine.position, ExceptionType.InvalidTypeException);
            }
            return Value.VoidValue;
        }
    }
}
