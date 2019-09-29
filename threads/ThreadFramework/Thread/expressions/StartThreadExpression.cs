using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using wolThread.classes;
using wolvm;

namespace wolThread.expressions
{
    public class StartThreadExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            Thread thread = null;
            try
            {
                thread = ((wolThreadClass)args[0].type).value;
            }
            catch (InvalidCastException)
            {
                VirtualMachine.ThrowVMException("Argument haven`t type Thread", VirtualMachine.position, ExceptionType.InvalidTypeException);
            }
            thread.Start();
            return Value.VoidValue;
        }
    }
}
