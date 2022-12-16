using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public abstract class TextWriterDecorator : TextWriter
    {
        protected TextWriter component;
        public override Encoding Encoding => Encoding.UTF8;
        public TextWriterDecorator(TextWriter component)
        {
            this.component = component;
        }
        public override void WriteLine(string text)
        {
            if(component != null)
            {
                component.WriteLine(text);
            }
            base.WriteLine(text);
        }
    }
}
