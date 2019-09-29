using System;
using System.Collections.Generic;
using System.Text;
using wolvm;

namespace Thread.classes
{
    public class wolThreadPriority : wolvm.Void
    {
        public wolThreadPriority() : base()
        {
            parents.Add("int", VirtualMachine.GetWolClass("int"));
            classType = wolClassType.ENUM;
        }
    }
}
