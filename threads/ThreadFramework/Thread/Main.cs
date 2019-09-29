using System;
using wolvm;
using wolThread.classes;
using System.Threading;

namespace wolThread
{
    public class Main : VMLibrary
    {
        public Main()
        {
            stack = new Stack();
            stack.classes.Add("Thread", new wolThreadClass());
            stack.values.Add("CurrentThread", new Value(new wolThreadClass(Thread.CurrentThread), SecurityModifer.PUBLIC, true));
        }
    }
}
