using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab8
{
    public class TextReaderDate : TextReaderDecorator
    {
        public TextReaderDate(TextReader component) : base(component) { }
        public override string ReadLine()
        {
            string Text = base.ReadLine();
            DateTime toDay = DateTime.Now;
            return Text == null ? null : $"[{toDay.Day}.{toDay.Month}.{toDay.Year} {toDay.Hour}:{toDay.Minute}:{toDay.Second}] {Text} ";
        }
    }
}
