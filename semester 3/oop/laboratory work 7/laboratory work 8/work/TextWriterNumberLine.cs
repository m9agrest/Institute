using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class TextWriterNumberLine : TextWriterDecorator
    {
        public TextWriterNumberLine(TextWriter component) : base(component) { }
        private int Line = 0;
        public override void WriteLine(string text)
        {
            Line++;
            string NewText = $"{Line}) {text}";
            base.WriteLine(NewText);
        }
    }
}
