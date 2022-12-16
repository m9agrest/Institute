using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class TextWriterDate : TextWriterDecorator
    {
        public TextWriterDate(TextWriter component) : base(component) { }
        public override void WriteLine(string text)
        {
            DateTime toDay = DateTime.Now;
            string NewText = $"{text} [{toDay.Day}.{toDay.Month}.{toDay.Year} {toDay.Hour}:{toDay.Minute}:{toDay.Second}]";
            base.WriteLine(NewText);
        }
    }
}
