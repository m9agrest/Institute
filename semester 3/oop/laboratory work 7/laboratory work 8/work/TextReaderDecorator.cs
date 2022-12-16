using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public abstract class TextReaderDecorator : TextReader
    {
        protected TextReader component;
        public TextReaderDecorator(TextReader component)
        {
            this.component = component;
        }
        public override string ReadLine()
        {
            if (component != null)
            {
                return component.ReadLine();
            }
            return "Decorator.ReadLine()";
        }
    }
}
