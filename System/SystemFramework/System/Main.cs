using System;
using wolSystem.classes;
using wolSystem.expressions;
using wolvm;

namespace wolSystem
{
    public class Main : VMLibrary
    {
        public Main()
        {
            stack.classes.Add("DateTime", new wolDateTime());
            stack.classes.Add("StreamReader", new wolStreamReader());
            stack.classes.Add("StreamWriter", new wolStreamWriter());
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
            expressions.Add("datetimenow", new DateTimeNowExpression());
            expressions.Add("datetimeparse", new DateTimeParseExpression());
            expressions.Add("openread", new OpenStreamReaderExpression());
            expressions.Add("openwrite", new OpenStreamWriterExpression());
            expressions.Add("closeread", new CloseStreamReaderExpression());
            expressions.Add("closewrite", new CloseStreamWriterExpression());
            expressions.Add("readline", new ReadLineExpression());
            expressions.Add("readtoend", new ReadToEndExpression());
            expressions.Add("writefile", new WriteFileExpression());
        }
    }
}
