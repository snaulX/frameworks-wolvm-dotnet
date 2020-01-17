using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using wolvm;

namespace wolSystem.classes
{
    public class wolStreamWriter : wolvm.Void
    {
        public new StreamWriter value;

        public wolStreamWriter() : base()
        {
            strtype = "StreamWriter";
        }

        public wolStreamWriter(StreamWriter stream) : this()
        {
            value = stream;
        }

        public override string ToString() => value.ToString();
    }
}
