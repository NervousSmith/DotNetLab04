using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Zadanie5_2_
{
    public class Osoby
    {
        [XmlElement("Osoba")]
        public List<Osoba> osoby;

        public Osoby()
        {
            osoby = new List<Osoba>();
        }

        public void Add(Osoba osobaDoDodania)
        {
            osoby.Add(osobaDoDodania);
        }

        public Osoba Get(int index)
        {
            return osoby[index];
        }

        public void Remove(Osoba osobaDoZabrania)
        {
            osoby.Remove(osobaDoZabrania);
        }

        public int Size()
        {
            return osoby.Count;
        }
    }
}
