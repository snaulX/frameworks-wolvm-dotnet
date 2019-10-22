using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using wolThread.classes;
using wolvm;

namespace wolThread.expressions
{
    public class JoinThreadExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args)
        {
            Thread thread = null;
            try
            {
                thread = ((wolThreadClass)args[0].type).value;
            }
            catch (Exception)
            {
                VirtualMachine.ThrowVMException("Argument haven`t type Thread", VirtualMachine.position, ExceptionType.InvalidTypeException);
            }
            try
            {
                thread.Join(((wolInt)args[1].type).value);
            }
            catch (Exception)
            {
                thread.Join();
            }
            return Value.VoidValue;
        }
    }
}
