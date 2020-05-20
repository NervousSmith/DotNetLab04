using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Zadanie5_2_
{
    public partial class Form1 : Form
    {
        static Osoby listaOsob;
        static string nazwaPlikuXml;

        public Form1()
        {
            InitializeComponent();
            listaOsob = new Osoby();
            nazwaPlikuXml = "osoby.xml";
        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            Osoba osobaDoDodania = new Osoba(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text));
            listaOsob.Add(osobaDoDodania);
            ListViewItem item1 = new ListViewItem(textBox1.Text);
            item1.SubItems.Add(textBox2.Text);
            item1.SubItems.Add(textBox3.Text);
            listView1.Items.Add(item1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Serializacja();
        }

        private void Serializacja()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Osoby));

            using (Stream fstream = new FileStream(nazwaPlikuXml, FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fstream, listaOsob);
            }
        }

        private void Deserializacja()
        {
            FileStream stream = new FileStream(nazwaPlikuXml, FileMode.Open);
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Osoby));

            listaOsob = (Osoby)xmlFormat.Deserialize(stream);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deserializacja();
            listView1.Items.Clear();
            for(int i = 0; i < listaOsob.Size(); i++)
            {
                ListViewItem item1 = new ListViewItem(listaOsob.Get(i).Imie);
                item1.SubItems.Add(listaOsob.Get(i).Nazwisko);
                item1.SubItems.Add(listaOsob.Get(i).Wiek.ToString());
                listView1.Items.Add(item1);
            }
        }
       
        
    }
}
