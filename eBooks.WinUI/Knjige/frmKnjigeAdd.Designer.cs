namespace eBooks.WinUI.Knjige
{
    partial class frmKnjigeAdd
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
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDodavanjeSlike = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDodavanjeKnjige = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDodajUzorak = new System.Windows.Forms.Button();
            this.txtDodavanjeUzorka = new System.Windows.Forms.TextBox();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.pbKnjigaNaslovna = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNazivIzdavaca = new System.Windows.Forms.TextBox();
            this.btnPretragaIzdavaci = new System.Windows.Forms.Button();
            this.btnPretragaKolekcije = new System.Windows.Forms.Button();
            this.txtNazivKolekcije = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtImeAutora = new System.Windows.Forms.TextBox();
            this.btnPretragaAutori = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPseudonimAutora = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNazivKnjige = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginalniNazivKnjige = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPrezimeAutora = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCijena = new System.Windows.Forms.MaskedTextBox();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.cbJezik = new System.Windows.Forms.ComboBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGodinaIzdanja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIzdanje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBrojStrana = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtOriginalniNazivKolekcije = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOdabraniAutori = new System.Windows.Forms.DataGridView();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pseudonim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajAutora = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clbKategorije = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKnjigaNaslovna)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniAutori)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDodajSliku);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtDodavanjeSlike);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtDodavanjeKnjige);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.btnDodajUzorak);
            this.groupBox5.Controls.Add(this.txtDodavanjeUzorka);
            this.groupBox5.Controls.Add(this.btnDodajKnjigu);
            this.groupBox5.Controls.Add(this.pbKnjigaNaslovna);
            this.groupBox5.Location = new System.Drawing.Point(529, 280);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(498, 368);
            this.groupBox5.TabIndex = 59;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dodavanje knjige";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(365, 194);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 30;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Slika naslovnice";
            // 
            // txtDodavanjeSlike
            // 
            this.txtDodavanjeSlike.Location = new System.Drawing.Point(171, 196);
            this.txtDodavanjeSlike.Name = "txtDodavanjeSlike";
            this.txtDodavanjeSlike.ReadOnly = true;
            this.txtDodavanjeSlike.Size = new System.Drawing.Size(150, 20);
            this.txtDodavanjeSlike.TabIndex = 23;
            this.txtDodavanjeSlike.Validating += new System.ComponentModel.CancelEventHandler(this.txtDodavanjeSlike_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Knjiga";
            // 
            // txtDodavanjeKnjige
            // 
            this.txtDodavanjeKnjige.Location = new System.Drawing.Point(171, 249);
            this.txtDodavanjeKnjige.Name = "txtDodavanjeKnjige";
            this.txtDodavanjeKnjige.ReadOnly = true;
            this.txtDodavanjeKnjige.Size = new System.Drawing.Size(150, 20);
            this.txtDodavanjeKnjige.TabIndex = 25;
            this.txtDodavanjeKnjige.Validating += new System.ComponentModel.CancelEventHandler(this.txtDodavanjeKnjige_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Besplatan uzorak knjige";
            // 
            // btnDodajUzorak
            // 
            this.btnDodajUzorak.Location = new System.Drawing.Point(365, 294);
            this.btnDodajUzorak.Name = "btnDodajUzorak";
            this.btnDodajUzorak.Size = new System.Drawing.Size(75, 23);
            this.btnDodajUzorak.TabIndex = 32;
            this.btnDodajUzorak.Text = "Dodaj";
            this.btnDodajUzorak.UseVisualStyleBackColor = true;
            this.btnDodajUzorak.Click += new System.EventHandler(this.btnDodajUzorak_Click);
            // 
            // txtDodavanjeUzorka
            // 
            this.txtDodavanjeUzorka.Location = new System.Drawing.Point(171, 296);
            this.txtDodavanjeUzorka.Name = "txtDodavanjeUzorka";
            this.txtDodavanjeUzorka.ReadOnly = true;
            this.txtDodavanjeUzorka.Size = new System.Drawing.Size(150, 20);
            this.txtDodavanjeUzorka.TabIndex = 27;
            this.txtDodavanjeUzorka.Validating += new System.ComponentModel.CancelEventHandler(this.txtDodavanjeUzorka_Validating);
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.Location = new System.Drawing.Point(365, 247);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajKnjigu.TabIndex = 31;
            this.btnDodajKnjigu.Text = "Dodaj";
            this.btnDodajKnjigu.UseVisualStyleBackColor = true;
            this.btnDodajKnjigu.Click += new System.EventHandler(this.btnDodajKnjigu_Click);
            // 
            // pbKnjigaNaslovna
            // 
            this.pbKnjigaNaslovna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbKnjigaNaslovna.Location = new System.Drawing.Point(195, 19);
            this.pbKnjigaNaslovna.Name = "pbKnjigaNaslovna";
            this.pbKnjigaNaslovna.Size = new System.Drawing.Size(106, 156);
            this.pbKnjigaNaslovna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbKnjigaNaslovna.TabIndex = 28;
            this.pbKnjigaNaslovna.TabStop = false;
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
            // txtNazivIzdavaca
            // 
            this.txtNazivIzdavaca.Location = new System.Drawing.Point(113, 26);
            this.txtNazivIzdavaca.Name = "txtNazivIzdavaca";
            this.txtNazivIzdavaca.ReadOnly = true;
            this.txtNazivIzdavaca.Size = new System.Drawing.Size(150, 20);
            this.txtNazivIzdavaca.TabIndex = 38;
            this.txtNazivIzdavaca.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivIzdavaca_Validating);
            // 
            // btnPretragaIzdavaci
            // 
            this.btnPretragaIzdavaci.Location = new System.Drawing.Point(308, 24);
            this.btnPretragaIzdavaci.Name = "btnPretragaIzdavaci";
            this.btnPretragaIzdavaci.Size = new System.Drawing.Size(75, 23);
            this.btnPretragaIzdavaci.TabIndex = 39;
            this.btnPretragaIzdavaci.Text = "Pretraga";
            this.btnPretragaIzdavaci.UseVisualStyleBackColor = true;
            this.btnPretragaIzdavaci.Click += new System.EventHandler(this.btnPretragaIzdavaci_Click);
            // 
            // btnPretragaKolekcije
            // 
            this.btnPretragaKolekcije.Location = new System.Drawing.Point(308, 54);
            this.btnPretragaKolekcije.Name = "btnPretragaKolekcije";
            this.btnPretragaKolekcije.Size = new System.Drawing.Size(75, 23);
            this.btnPretragaKolekcije.TabIndex = 41;
            this.btnPretragaKolekcije.Text = "Pretraga";
            this.btnPretragaKolekcije.UseVisualStyleBackColor = true;
            this.btnPretragaKolekcije.Click += new System.EventHandler(this.btnPretragaKolekcije_Click);
            // 
            // txtNazivKolekcije
            // 
            this.txtNazivKolekcije.Location = new System.Drawing.Point(128, 27);
            this.txtNazivKolekcije.Name = "txtNazivKolekcije";
            this.txtNazivKolekcije.ReadOnly = true;
            this.txtNazivKolekcije.Size = new System.Drawing.Size(150, 20);
            this.txtNazivKolekcije.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Ime";
            // 
            // txtImeAutora
            // 
            this.txtImeAutora.Location = new System.Drawing.Point(111, 20);
            this.txtImeAutora.Name = "txtImeAutora";
            this.txtImeAutora.ReadOnly = true;
            this.txtImeAutora.Size = new System.Drawing.Size(150, 20);
            this.txtImeAutora.TabIndex = 43;
            this.txtImeAutora.Validating += new System.ComponentModel.CancelEventHandler(this.txtImeAutora_Validating);
            // 
            // btnPretragaAutori
            // 
            this.btnPretragaAutori.Location = new System.Drawing.Point(301, 83);
            this.btnPretragaAutori.Name = "btnPretragaAutori";
            this.btnPretragaAutori.Size = new System.Drawing.Size(75, 23);
            this.btnPretragaAutori.TabIndex = 44;
            this.btnPretragaAutori.Text = "Pretraga";
            this.btnPretragaAutori.UseVisualStyleBackColor = true;
            this.btnPretragaAutori.Click += new System.EventHandler(this.btnPretragaAutori_Click);
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
            // txtPseudonimAutora
            // 
            this.txtPseudonimAutora.Location = new System.Drawing.Point(111, 86);
            this.txtPseudonimAutora.Name = "txtPseudonimAutora";
            this.txtPseudonimAutora.ReadOnly = true;
            this.txtPseudonimAutora.Size = new System.Drawing.Size(150, 20);
            this.txtPseudonimAutora.TabIndex = 48;
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
            this.groupBox1.TabIndex = 55;
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
            this.txtNazivKnjige.Size = new System.Drawing.Size(200, 20);
            this.txtNazivKnjige.TabIndex = 1;
            this.txtNazivKnjige.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivKnjige_Validating);
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
            this.txtOriginalniNazivKnjige.Size = new System.Drawing.Size(200, 20);
            this.txtOriginalniNazivKnjige.TabIndex = 3;
            this.txtOriginalniNazivKnjige.Validating += new System.ComponentModel.CancelEventHandler(this.txtOriginalniNazivKnjige_Validating);
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
            this.txtSadrzaj.Size = new System.Drawing.Size(372, 150);
            this.txtSadrzaj.TabIndex = 20;
            this.txtSadrzaj.Text = "";
            this.txtSadrzaj.Validating += new System.ComponentModel.CancelEventHandler(this.txtSadrzaj_Validating);
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Prezime";
            // 
            // txtPrezimeAutora
            // 
            this.txtPrezimeAutora.Location = new System.Drawing.Point(111, 54);
            this.txtPrezimeAutora.Name = "txtPrezimeAutora";
            this.txtPrezimeAutora.ReadOnly = true;
            this.txtPrezimeAutora.Size = new System.Drawing.Size(150, 20);
            this.txtPrezimeAutora.TabIndex = 46;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCijena);
            this.groupBox2.Controls.Add(this.cbFormat);
            this.groupBox2.Controls.Add(this.cbJezik);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtNazivIzdavaca);
            this.groupBox2.Controls.Add(this.btnPretragaIzdavaci);
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
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o izdanju";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(414, 124);
            this.txtCijena.Mask = "000.00";
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(57, 20);
            this.txtCijena.TabIndex = 53;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // cbFormat
            // 
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(246, 93);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(75, 21);
            this.cbFormat.TabIndex = 52;
            this.cbFormat.Validating += new System.ComponentModel.CancelEventHandler(this.cbFormat_Validating);
            // 
            // cbJezik
            // 
            this.cbJezik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJezik.FormattingEnabled = true;
            this.cbJezik.Location = new System.Drawing.Point(246, 125);
            this.cbJezik.Name = "cbJezik";
            this.cbJezik.Size = new System.Drawing.Size(75, 21);
            this.cbJezik.TabIndex = 51;
            this.cbJezik.Validating += new System.ComponentModel.CancelEventHandler(this.cbJezik_Validating);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(113, 61);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(150, 20);
            this.txtISBN.TabIndex = 7;
            this.txtISBN.Validating += new System.ComponentModel.CancelEventHandler(this.txtISBN_Validating);
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
            this.txtGodinaIzdanja.Size = new System.Drawing.Size(52, 20);
            this.txtGodinaIzdanja.TabIndex = 9;
            this.txtGodinaIzdanja.Validating += new System.ComponentModel.CancelEventHandler(this.txtGodinaIzdanja_Validating);
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
            this.txtIzdanje.Size = new System.Drawing.Size(52, 20);
            this.txtIzdanje.TabIndex = 15;
            this.txtIzdanje.Validating += new System.ComponentModel.CancelEventHandler(this.txtIzdanje_Validating);
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
            // txtBrojStrana
            // 
            this.txtBrojStrana.Location = new System.Drawing.Point(414, 94);
            this.txtBrojStrana.Name = "txtBrojStrana";
            this.txtBrojStrana.Size = new System.Drawing.Size(57, 20);
            this.txtBrojStrana.TabIndex = 11;
            this.txtBrojStrana.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojStrana_Validating);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtOriginalniNazivKolekcije);
            this.groupBox4.Controls.Add(this.btnPretragaKolekcije);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtNazivKolekcije);
            this.groupBox4.Location = new System.Drawing.Point(529, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(498, 91);
            this.groupBox4.TabIndex = 58;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvOdabraniAutori);
            this.groupBox3.Controls.Add(this.btnDodajAutora);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtImeAutora);
            this.groupBox3.Controls.Add(this.btnPretragaAutori);
            this.groupBox3.Controls.Add(this.txtPseudonimAutora);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtPrezimeAutora);
            this.groupBox3.Location = new System.Drawing.Point(12, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 335);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o autorima";
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
            this.dgvOdabraniAutori.Location = new System.Drawing.Point(6, 139);
            this.dgvOdabraniAutori.Name = "dgvOdabraniAutori";
            this.dgvOdabraniAutori.ReadOnly = true;
            this.dgvOdabraniAutori.Size = new System.Drawing.Size(499, 190);
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
            // btnDodajAutora
            // 
            this.btnDodajAutora.Location = new System.Drawing.Point(408, 83);
            this.btnDodajAutora.Name = "btnDodajAutora";
            this.btnDodajAutora.Size = new System.Drawing.Size(75, 23);
            this.btnDodajAutora.TabIndex = 49;
            this.btnDodajAutora.Text = "Dodaj";
            this.btnDodajAutora.UseVisualStyleBackColor = true;
            this.btnDodajAutora.Click += new System.EventHandler(this.btnDodajAutora_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Pseudonim";
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSnimi.Location = new System.Drawing.Point(519, 683);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(106, 33);
            this.btnSnimi.TabIndex = 60;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clbKategorije);
            this.groupBox6.Location = new System.Drawing.Point(1033, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(164, 636);
            this.groupBox6.TabIndex = 61;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kategorije";
            // 
            // clbKategorije
            // 
            this.clbKategorije.FormattingEnabled = true;
            this.clbKategorije.Location = new System.Drawing.Point(6, 20);
            this.clbKategorije.Name = "clbKategorije";
            this.clbKategorije.Size = new System.Drawing.Size(135, 604);
            this.clbKategorije.TabIndex = 0;
            this.clbKategorije.Validating += new System.ComponentModel.CancelEventHandler(this.clbKategorije_Validating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmKnjigeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 740);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSnimi);
            this.Name = "frmKnjigeAdd";
            this.Text = "Dodavanje nove knjige";
            this.Load += new System.EventHandler(this.frmKnjigeAdd_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKnjigaNaslovna)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniAutori)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDodavanjeSlike;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDodavanjeKnjige;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDodajUzorak;
        private System.Windows.Forms.TextBox txtDodavanjeUzorka;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.PictureBox pbKnjigaNaslovna;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNazivIzdavaca;
        private System.Windows.Forms.Button btnPretragaIzdavaci;
        private System.Windows.Forms.Button btnPretragaKolekcije;
        private System.Windows.Forms.TextBox txtNazivKolekcije;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtImeAutora;
        private System.Windows.Forms.Button btnPretragaAutori;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPseudonimAutora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNazivKnjige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginalniNazivKnjige;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtSadrzaj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPrezimeAutora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.ComboBox cbJezik;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGodinaIzdanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIzdanje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBrojStrana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtOriginalniNazivKolekcije;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDodajAutora;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.DataGridView dgvOdabraniAutori;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pseudonim;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckedListBox clbKategorije;
        private System.Windows.Forms.MaskedTextBox txtCijena;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}