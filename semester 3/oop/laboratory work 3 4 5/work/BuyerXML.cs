using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab345
{
    class BuyerXML
    {
        public List<Buyer> Buyers;
        public void Save(string FileName)
        {

        }
        public void Load(string FileName)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(FileName);
            XmlElement xBuyers = xDoc.DocumentElement;
            int BuyersCount = xBuyers.ChildNodes.Count;
            foreach (XmlNode xBuyer in xBuyers)
                Buyers.Add(new Buyer(xBuyer));
        }

        public BuyerXML() => Buyers = new List<Buyer>();
        public BuyerXML(string FileName) : this() => Load(FileName);
    }
}
