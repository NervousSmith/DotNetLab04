using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Zadanie5_2_
{
    [XmlRoot(ElementName = "Osoba")]
    public class Osoba
    {
        [XmlElement(ElementName = "Imie")]
        public string Imie;
        [XmlElement(ElementName = "Nazwisko")]
        public string Nazwisko;
        [XmlElement(ElementName = "Wiek")]
        public int Wiek;
        
        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public Osoba()
        {
            Imie = "";
            Nazwisko = "";
            Wiek = 0;
        }

        public string ToString()
        {
            return "Imie: " + Imie + " Nazwisko: " + Nazwisko + " Wiek: " + Wiek;
        }

        public bool Equals(Osoba osoba)
        {
            bool equals = false;
            if (this.Imie == osoba.Imie && this.Nazwisko == osoba.Nazwisko && this.Wiek == osoba.Wiek)
            {
                equals = true;
            }
            return equals;
        }
    }

}
