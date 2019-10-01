using System;
using wolvm;
using wolThread.classes;
using System.Threading;
using System.Collections.Generic;
using wolThread.expressions;

namespace wolThread
{
    public class Main : VMLibrary
    {
        public Main()
        {
            expressions.Add("start-thread", new StartThreadExpression());
            stack.classes.Add("Thread", new wolThreadClass());
            stack.values.Add("CurrentThread", new Value(new wolThreadClass(Thread.CurrentThread), SecurityModifer.PUBLIC, true));
        }
    }
}
