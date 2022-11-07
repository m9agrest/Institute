using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.task2
{
    class ComputerStore : IEnumerable<Laptop>
    {
        public List<Laptop> ListLaptop;
        public string Name;
        public string Address;
        public IEnumerator GetEnumerator() => ListLaptop.GetEnumerator();
        IEnumerator<Laptop> IEnumerable<Laptop>.GetEnumerator() => ListLaptop.GetEnumerator();
    }
}
