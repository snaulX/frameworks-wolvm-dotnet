using System;
using wolvm;

namespace wolSystem
{
    public class Main : VMLibrary
    {
        public Main()
        {
            expressions.Add("print", new PrintExpression());
        }
    }
}
