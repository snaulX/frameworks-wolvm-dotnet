using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using wolvm;

namespace wolSystem.classes
{
    public class wolStreamReader : wolvm.Void
    {
        public StreamReader value;

        public wolStreamReader() : base()
        {
            strtype = "StreamReader";
        }

        public wolStreamReader(StreamReader stream) : this()
        {
            value = stream;
        }

        public override string ToString() => value.ToString();
    }
}
