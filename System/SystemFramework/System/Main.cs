using System;
using wolSystem.expressions;
using wolvm;

namespace wolSystem
{
    public class Main : VMLibrary
    {
        public Main()
        {
            expressions.Add("print", new expressions.PrintExpression());
            expressions.Add("input", new expressions.InputExpression());
            expressions.Add("sleep", new SleepExpression());
        }
    }
}
