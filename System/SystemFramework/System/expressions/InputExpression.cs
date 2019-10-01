using System;
using wolvm;

namespace wolSystem.expressions
{
    public class InputExpression : VMExpression
    {
        public Value ParseExpression(params Value[] args) => new Value(new wolString(Console.ReadLine()));
    }
}
