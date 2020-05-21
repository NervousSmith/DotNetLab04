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
using System.Xml.Serialization;

namespace Zadanie7_4_
{
    public partial class Form1 : Form
    {
        Osoby listaOsob;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("osoby.xml", FileMode.Open);
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Osoby));
            listaOsob = (Osoby)xmlFormat.Deserialize(stream);

            TreeNode osoby = new TreeNode("Osoby");
            treeView1.Nodes.Add(osoby);

            Osoba osobaDoNode;
            for(int i = 0; i < listaOsob.Size(); i++)
            {
                TreeNode osoba = new TreeNode("Osoba " + (i+1));
                osobaDoNode = listaOsob.Get(i);
                TreeNode imie = new TreeNode("Imie");
                imie.Text = osobaDoNode.Imie;
                TreeNode nazwisko = new TreeNode("Nazwisko");
                nazwisko.Text = osobaDoNode.Nazwisko;
                TreeNode wiek = new TreeNode("Wiek");
                wiek.Text = osobaDoNode.Wiek.ToString();
                osoba.Nodes.Add(imie);
                osoba.Nodes.Add(nazwisko);
                osoba.Nodes.Add(wiek);
                osoby.Nodes.Add(osoba);
            }
        }
    }
}
