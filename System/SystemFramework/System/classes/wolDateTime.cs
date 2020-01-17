using System;
using System.Collections.Generic;
using System.Text;
using wolvm;

namespace wolSystem.classes
{
    public class wolDateTime : wolvm.Void
    {
        public new DateTime value;

        public wolDateTime() : base()
        {
            strtype = "DateTime";
        }

        public wolDateTime(DateTime dateTime) : this()
        {
            value = dateTime;
        }

        public override string ToString() => value.ToLongDateString();
    }
}
