using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Zadanie4_1_
{
    class Program
    {
        static Osoba os1;
        static Osoba os2;
       
        static string nazwaPlikuXml;

        static void Main(string[] args)
        {
            int caseSwitch = 0;
            nazwaPlikuXml = "osoby.xml";
            
            while (caseSwitch != 9)
            {
                Console.WriteLine("1 - Utwórz osobe");
                Console.WriteLine("2 - Serializuj osobe");
                Console.WriteLine("3 - Deserializuj osobe");
                Console.WriteLine("4 - Wyświetl deserializowane osobe");
                Console.WriteLine("9 - Zakończ");
                caseSwitch = Int32.Parse(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        StworzOsobe();
                        break;
                    case 2:
                        Serializacja();
                        break;
                    case 3:
                        Deserializacja();
                        break;
                    case 4:
                        Console.WriteLine(os2.ToString());
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            
        }

        private static void StworzOsobe()
        {
            string imie, nazwisko;
            int wiek;
            Console.WriteLine("Podaj imie osoby");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko osoby");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj wiek osoby");
            wiek = Int32.Parse(Console.ReadLine());
            os1 = new Osoba(imie, nazwisko, wiek);
            Console.WriteLine("Osoba została utworzona! " + os1.ToString());
        }

        private static void Serializacja()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Osoba));

            using (Stream fstream = new FileStream(nazwaPlikuXml, FileMode.Create, 
                FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fstream, os1);
            }
        }

        private static void Deserializacja()
        {
            FileStream stream = new FileStream(nazwaPlikuXml, FileMode.Open);
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Osoba));

            os2 = (Osoba)xmlFormat.Deserialize(stream);
        }
    }
}
