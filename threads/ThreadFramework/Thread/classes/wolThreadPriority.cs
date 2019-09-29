using System;
using System.Collections.Generic;
using System.Text;
using wolvm;

namespace wolThread.classes
{
    public class wolThreadPriority : wolvm.Void
    {
        public wolThreadPriority() : base()
        {
            strtype = "ThreadPriority";
            parents.Add("int", VirtualMachine.GetWolClass("int"));
            classType = wolClassType.ENUM;
        }
    }
}
