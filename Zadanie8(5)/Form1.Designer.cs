namespace Zadanie6
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nr_telefonu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_urodzenia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.printBTN = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.previewBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nazwisko,
            this.Imie,
            this.nr_telefonu,
            this.Data_urodzenia});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(695, 348);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nazwisko
            // 
            this.Nazwisko.DisplayIndex = 1;
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.Width = 89;
            // 
            // Imie
            // 
            this.Imie.DisplayIndex = 0;
            this.Imie.Text = "Imie";
            this.Imie.Width = 81;
            // 
            // nr_telefonu
            // 
            this.nr_telefonu.Text = "Nr telefonu";
            this.nr_telefonu.Width = 138;
            // 
            // Data_urodzenia
            // 
            this.Data_urodzenia.Text = "Data urodzenia";
            this.Data_urodzenia.Width = 272;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Książka teleadresowa";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(713, 343);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 26);
            this.add.TabIndex = 2;
            this.add.Text = "Dodaj";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(713, 375);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(100, 26);
            this.del.TabIndex = 3;
            this.del.Text = "Usuń";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(713, 79);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 26);
            this.search.TabIndex = 4;
            this.search.Text = "Szukaj";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(713, 53);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(274, 20);
            this.find.TabIndex = 5;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(713, 191);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(274, 20);
            this.name.TabIndex = 6;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(713, 230);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(274, 20);
            this.surname.TabIndex = 7;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(713, 272);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(274, 20);
            this.phone.TabIndex = 8;
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(713, 317);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(274, 20);
            this.birth.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sortowanie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Numer telefonu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nazwisko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Imie";
            // 
            // printBTN
            // 
            this.printBTN.Location = new System.Drawing.Point(820, 343);
            this.printBTN.Name = "printBTN";
            this.printBTN.Size = new System.Drawing.Size(104, 26);
            this.printBTN.TabIndex = 17;
            this.printBTN.Text = "Drukuj";
            this.printBTN.UseVisualStyleBackColor = true;
            this.printBTN.Click += new System.EventHandler(this.printBTN_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // previewBTN
            // 
            this.previewBTN.Location = new System.Drawing.Point(820, 376);
            this.previewBTN.Name = "previewBTN";
            this.previewBTN.Size = new System.Drawing.Size(104, 23);
            this.previewBTN.TabIndex = 18;
            this.previewBTN.Text = "Podgląd Wydruku";
            this.previewBTN.UseVisualStyleBackColor = true;
            this.previewBTN.Click += new System.EventHandler(this.previewBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 472);
            this.Controls.Add(this.previewBTN);
            this.Controls.Add(this.printBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.find);
            this.Controls.Add(this.search);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ColumnHeader Imie;
        private System.Windows.Forms.ColumnHeader Nazwisko;
        private System.Windows.Forms.ColumnHeader nr_telefonu;
        private System.Windows.Forms.ColumnHeader Data_urodzenia;
        private System.Windows.Forms.TextBox find;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox birth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button printBTN;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button previewBTN;
    }
}

