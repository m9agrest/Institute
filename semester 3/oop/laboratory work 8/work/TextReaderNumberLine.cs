using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class TextReaderNumberLine : TextReaderDecorator
    {
        private int Line;
        public TextReaderNumberLine(TextReader component) : base(component) { }
        public override string ReadLine()
        {
            string Text = base.ReadLine();
            return Text == null ? null : $"{Line++}. {Text}";
        }
    }
}
