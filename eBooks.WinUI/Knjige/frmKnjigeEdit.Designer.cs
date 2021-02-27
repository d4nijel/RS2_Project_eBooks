namespace eBooks.WinUI.Knjige
{
    partial class frmKnjigeEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGodinaIzdanja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIzdanje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvOdabraniAutori = new System.Windows.Forms.DataGridView();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pseudonim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBrojStrana = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clbKategorije = new System.Windows.Forms.CheckedListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtOriginalniNazivKolekcije = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNazivKolekcije = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pbKnjigaNaslovna = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNazivIzdavaca = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNazivKnjige = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginalniNazivKnjige = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtJezik = new System.Windows.Forms.TextBox();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnKnjiga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniAutori)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKnjigaNaslovna)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(113, 61);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(150, 20);
            this.txtISBN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ISBN";
            // 
            // txtGodinaIzdanja
            // 
            this.txtGodinaIzdanja.Location = new System.Drawing.Point(113, 125);
            this.txtGodinaIzdanja.Name = "txtGodinaIzdanja";
            this.txtGodinaIzdanja.ReadOnly = true;
            this.txtGodinaIzdanja.Size = new System.Drawing.Size(52, 20);
            this.txtGodinaIzdanja.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Godina izdanja";
            // 
            // txtIzdanje
            // 
            this.txtIzdanje.Location = new System.Drawing.Point(113, 94);
            this.txtIzdanje.Name = "txtIzdanje";
            this.txtIzdanje.ReadOnly = true;
            this.txtIzdanje.Size = new System.Drawing.Size(52, 20);
            this.txtIzdanje.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Izdanje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Jezik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Format";
            // 
            // dgvOdabraniAutori
            // 
            this.dgvOdabraniAutori.AllowUserToAddRows = false;
            this.dgvOdabraniAutori.AllowUserToDeleteRows = false;
            this.dgvOdabraniAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabraniAutori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorID,
            this.Ime,
            this.Prezime,
            this.Pseudonim});
            this.dgvOdabraniAutori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOdabraniAutori.Enabled = false;
            this.dgvOdabraniAutori.Location = new System.Drawing.Point(3, 16);
            this.dgvOdabraniAutori.Name = "dgvOdabraniAutori";
            this.dgvOdabraniAutori.ReadOnly = true;
            this.dgvOdabraniAutori.Size = new System.Drawing.Size(505, 194);
            this.dgvOdabraniAutori.TabIndex = 50;
            // 
            // AuthorID
            // 
            this.AuthorID.DataPropertyName = "AuthorID";
            this.AuthorID.HeaderText = "AuthorID";
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.ReadOnly = true;
            this.AuthorID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Pseudonim
            // 
            this.Pseudonim.DataPropertyName = "Pseudonim";
            this.Pseudonim.HeaderText = "Pseudonim";
            this.Pseudonim.Name = "Pseudonim";
            this.Pseudonim.ReadOnly = true;
            // 
            // txtBrojStrana
            // 
            this.txtBrojStrana.Location = new System.Drawing.Point(414, 94);
            this.txtBrojStrana.Name = "txtBrojStrana";
            this.txtBrojStrana.ReadOnly = true;
            this.txtBrojStrana.Size = new System.Drawing.Size(57, 20);
            this.txtBrojStrana.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Broj strana";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cijena";
            // 
            // clbKategorije
            // 
            this.clbKategorije.Enabled = false;
            this.clbKategorije.FormattingEnabled = true;
            this.clbKategorije.Location = new System.Drawing.Point(6, 20);
            this.clbKategorije.Name = "clbKategorije";
            this.clbKategorije.Size = new System.Drawing.Size(135, 484);
            this.clbKategorije.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clbKategorije);
            this.groupBox6.Location = new System.Drawing.Point(1033, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(149, 514);
            this.groupBox6.TabIndex = 68;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kategorije";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtOriginalniNazivKolekcije);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtNazivKolekcije);
            this.groupBox4.Location = new System.Drawing.Point(529, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(498, 91);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kolekcija";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Originalni naziv";
            // 
            // txtOriginalniNazivKolekcije
            // 
            this.txtOriginalniNazivKolekcije.Location = new System.Drawing.Point(128, 56);
            this.txtOriginalniNazivKolekcije.Name = "txtOriginalniNazivKolekcije";
            this.txtOriginalniNazivKolekcije.ReadOnly = true;
            this.txtOriginalniNazivKolekcije.Size = new System.Drawing.Size(150, 20);
            this.txtOriginalniNazivKolekcije.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Naziv";
            // 
            // txtNazivKolekcije
            // 
            this.txtNazivKolekcije.Location = new System.Drawing.Point(128, 27);
            this.txtNazivKolekcije.Name = "txtNazivKolekcije";
            this.txtNazivKolekcije.ReadOnly = true;
            this.txtNazivKolekcije.Size = new System.Drawing.Size(150, 20);
            this.txtNazivKolekcije.TabIndex = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvOdabraniAutori);
            this.groupBox3.Location = new System.Drawing.Point(12, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 213);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o autorima";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnKnjiga);
            this.groupBox5.Controls.Add(this.pbKnjigaNaslovna);
            this.groupBox5.Location = new System.Drawing.Point(529, 280);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(498, 246);
            this.groupBox5.TabIndex = 66;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Slika naslovnice";
            // 
            // pbKnjigaNaslovna
            // 
            this.pbKnjigaNaslovna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbKnjigaNaslovna.Location = new System.Drawing.Point(186, 19);
            this.pbKnjigaNaslovna.Name = "pbKnjigaNaslovna";
            this.pbKnjigaNaslovna.Padding = new System.Windows.Forms.Padding(4);
            this.pbKnjigaNaslovna.Size = new System.Drawing.Size(140, 210);
            this.pbKnjigaNaslovna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKnjigaNaslovna.TabIndex = 28;
            this.pbKnjigaNaslovna.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Naziv izdavača";
            // 
            // txtNazivIzdavaca
            // 
            this.txtNazivIzdavaca.Location = new System.Drawing.Point(113, 26);
            this.txtNazivIzdavaca.Name = "txtNazivIzdavaca";
            this.txtNazivIzdavaca.ReadOnly = true;
            this.txtNazivIzdavaca.Size = new System.Drawing.Size(150, 20);
            this.txtNazivIzdavaca.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSifra);
            this.groupBox1.Controls.Add(this.txtNazivKnjige);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOriginalniNazivKnjige);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSadrzaj);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 295);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(111, 94);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.ReadOnly = true;
            this.txtSifra.Size = new System.Drawing.Size(200, 20);
            this.txtSifra.TabIndex = 49;
            // 
            // txtNazivKnjige
            // 
            this.txtNazivKnjige.Location = new System.Drawing.Point(111, 29);
            this.txtNazivKnjige.Name = "txtNazivKnjige";
            this.txtNazivKnjige.ReadOnly = true;
            this.txtNazivKnjige.Size = new System.Drawing.Size(200, 20);
            this.txtNazivKnjige.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtOriginalniNazivKnjige
            // 
            this.txtOriginalniNazivKnjige.Location = new System.Drawing.Point(111, 62);
            this.txtOriginalniNazivKnjige.Name = "txtOriginalniNazivKnjige";
            this.txtOriginalniNazivKnjige.ReadOnly = true;
            this.txtOriginalniNazivKnjige.Size = new System.Drawing.Size(200, 20);
            this.txtOriginalniNazivKnjige.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Originalni naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Šifra";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(111, 125);
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.ReadOnly = true;
            this.txtSadrzaj.Size = new System.Drawing.Size(372, 150);
            this.txtSadrzaj.TabIndex = 20;
            this.txtSadrzaj.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Sadržaj";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCijena);
            this.groupBox2.Controls.Add(this.txtJezik);
            this.groupBox2.Controls.Add(this.txtFormat);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtNazivIzdavaca);
            this.groupBox2.Controls.Add(this.txtISBN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtGodinaIzdanja);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtIzdanje);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBrojStrana);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(529, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 165);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o izdanju";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(414, 124);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(57, 20);
            this.txtCijena.TabIndex = 42;
            // 
            // txtJezik
            // 
            this.txtJezik.Location = new System.Drawing.Point(250, 125);
            this.txtJezik.Name = "txtJezik";
            this.txtJezik.ReadOnly = true;
            this.txtJezik.Size = new System.Drawing.Size(52, 20);
            this.txtJezik.TabIndex = 41;
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(250, 94);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.ReadOnly = true;
            this.txtFormat.Size = new System.Drawing.Size(52, 20);
            this.txtFormat.TabIndex = 40;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnKnjiga
            // 
            this.btnKnjiga.Location = new System.Drawing.Point(354, 205);
            this.btnKnjiga.Name = "btnKnjiga";
            this.btnKnjiga.Size = new System.Drawing.Size(117, 24);
            this.btnKnjiga.TabIndex = 38;
            this.btnKnjiga.Text = "Pogledaj knjigu";
            this.btnKnjiga.UseVisualStyleBackColor = true;
            this.btnKnjiga.Click += new System.EventHandler(this.btnKnjiga_Click);
            // 
            // frmKnjigeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 542);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmKnjigeEdit";
            this.Text = "Pregled podataka o knjizi";
            this.Load += new System.EventHandler(this.frmKnjigeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniAutori)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKnjigaNaslovna)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGodinaIzdanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIzdanje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvOdabraniAutori;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pseudonim;
        private System.Windows.Forms.TextBox txtBrojStrana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckedListBox clbKategorije;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtOriginalniNazivKolekcije;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNazivKolekcije;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pbKnjigaNaslovna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNazivKnjige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginalniNazivKnjige;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtSadrzaj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNazivIzdavaca;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtJezik;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnKnjiga;
    }
}