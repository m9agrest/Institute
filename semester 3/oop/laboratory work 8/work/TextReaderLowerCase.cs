using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class TextReaderLowerCase : TextReaderDecorator
    {
        public TextReaderLowerCase(TextReader component) : base(component) { }
        public override string ReadLine()
        {
            string Text = base.ReadLine();
            return Text == null ? null : Text.ToLower();
        }

    }
}
