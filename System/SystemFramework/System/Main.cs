﻿using System;
using wolSystem.expressions;
using wolvm;

namespace wolSystem
{
    public class Main : VMLibrary
    {
        public Main()
        {
            expressions.Add("print", new PrintExpression());
            expressions.Add("input", new InputExpression());
            expressions.Add("sleep", new SleepExpression());
            expressions.Add("consolebg", new ConsoleBgExpression());
            expressions.Add("consoletitle", new ConsoleTitleExpression());
            expressions.Add("clear", new ConsoleClearExpression());
            expressions.Add("beep", new BeepExpression());
            expressions.Add("readkey", new ReadKeyExpression());
            expressions.Add("exit", new ExitExpression());
            expressions.Add("random", new RandomExpression());
        }
    }
}
