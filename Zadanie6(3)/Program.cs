using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Zadanie6_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseDtd();
            UseSchema();
        }

        private static void UseSchema()
        {
            Console.WriteLine("Walidacja pliku XML za pomocą XML Schema");
            Console.ReadLine();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas.Add("http://tempuri.org/XMLSchema1.xsd", "XMLSchema1.xsd");
            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
            XmlReader reader = XmlReader.Create("osoby.xml", settings);
            XmlDocument document = new XmlDocument();
            document.Load(reader);
            document.Validate(eventHandler);
        }

        private static void UseDtd()
        {
            Console.WriteLine("Walidacja pliku XML za pomocą DTD");
            Console.ReadLine();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationType = ValidationType.DTD;
            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
            XmlReader reader = XmlReader.Create("osoby.xml", settings);
            while (reader.Read()) ;
        }

        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);
                    break;
            }
        }
    }
}
