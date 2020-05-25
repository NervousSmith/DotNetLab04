using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Zadanie6
{
    public partial class Form1 : Form
    {
        string printString = "Imię Nazwisko Nr_Telefonu Data Urodzenia\n\n";
        public Form1()
        {
            InitializeComponent();
            ListViewItem person = new ListViewItem("Kordas");
            person.SubItems.Add("Ksawery");
            person.SubItems.Add("217-50-42");
            person.SubItems.Add("01.01.1984");
            listView1.Items.Add(person);
            ListViewItem person1 = new ListViewItem("Pieczka");
            person1.SubItems.Add("Klaudiusz");
            person1.SubItems.Add("668-56-33");
            person1.SubItems.Add("03.12.2000");
            listView1.Items.Add(person1);
            ListViewItem person2= new ListViewItem("Mączka");
            person2.SubItems.Add("Adam");
            person2.SubItems.Add("954-09-65");
            person2.SubItems.Add("05.06.1998");
            listView1.Items.Add(person2);
        }

        private void add_Click(object sender, EventArgs e)
        {
            ListViewItem person = new ListViewItem(surname.Text);
            person.SubItems.Add(name.Text);
            person.SubItems.Add(phone.Text);
            person.SubItems.Add(birth.Text);
            listView1.Items.Add(person);
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.SelectedItems[0].Remove();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("błąd");
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (find.Text != null && find.Text != "")
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.Text.ToLower().Contains(find.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Ascending;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            preparePrint();

            printDocument1.Print();
            printString = "Imię Nazwisko Nr_Telefonu Data Urodzenia\n\n";
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printString, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void previewBTN_Click(object sender, EventArgs e)
        {
            preparePrint();

            printPreviewDialog1.ShowDialog();
            printString = "Imię Nazwisko Nr_Telefonu Data Urodzenia\n\n";
        }

        private void preparePrint()
        {
            var SelectedItems = listView1.SelectedItems;
            var NoSelectedItems = listView1.Items;

            if (SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in SelectedItems)
                {
                    printString += item.SubItems[1].Text + " " + item.SubItems[0].Text + " "
                        + item.SubItems[2].Text + " " + item.SubItems[3].Text + "\n";
                }
            }
            else
            {
                foreach (ListViewItem item in NoSelectedItems)
                {
                    printString += item.SubItems[1].Text + " " + item.SubItems[0].Text + " "
                        + item.SubItems[2].Text + " " + item.SubItems[3].Text + "\n";
                }
            }
        }
    }
}