using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.task1
{
    interface IClean
    {
        public double DegreeContamination { get; set; }
        public void CleanUp();
        public DateTime CleaningTime();
    }
}
