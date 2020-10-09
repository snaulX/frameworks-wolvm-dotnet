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
            expressions.Add("StartThread", new StartThreadExpression());
            expressions.Add("AbortThread", new AbortThreadExpression());
            expressions.Add("JoinThread", new JoinThreadExpression());
            stack.classes.Add("Thread", new wolThreadClass());
            stack.classes.Add("ThreadPriority", new wolThreadPriority());
            stack.values.Add("CurrentThread", new Value(new wolThreadClass(Thread.CurrentThread), SecurityModifer.PUBLIC, true));
        }
    }
}
