using System;
using System.Collections.Generic;
using System.Text;
using wolvm;
using System.Threading;

namespace wolThread.classes
{
    public class wolThreadClass : wolvm.Void
    {
        public Thread value = Thread.CurrentThread;

        public wolThreadClass() : base()
        {
        }

        public wolThreadClass(Thread val) : this()
        {
            value = val;
        }
    }
}
