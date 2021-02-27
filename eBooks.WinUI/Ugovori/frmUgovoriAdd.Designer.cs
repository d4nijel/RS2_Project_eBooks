namespace eBooks.WinUI.Ugovori
{
    partial class frmUgovoriAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProcenat = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDatumPotpisivanja = new System.Windows.Forms.DateTimePicker();
            this.btnDodajUgovor = new System.Windows.Forms.Button();
            this.txtUgovor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrajanjeUgovora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojUgovora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNazivIzdavaca = new System.Windows.Forms.TextBox();
            this.btnPretragaIzdavaci = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProcenat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpDatumPotpisivanja);
            this.groupBox1.Controls.Add(this.btnDodajUgovor);
            this.groupBox1.Controls.Add(this.txtUgovor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTrajanjeUgovora);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBrojUgovora);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novi ugovor";
            // 
            // txtProcenat
            // 
            this.txtProcenat.Location = new System.Drawing.Point(144, 164);
            this.txtProcenat.Mask = "000.00";
            this.txtProcenat.Name = "txtProcenat";
            this.txtProcenat.Size = new System.Drawing.Size(50, 20);
            this.txtProcenat.TabIndex = 15;
            this.txtProcenat.ValidatingType = typeof(int);
            this.txtProcenat.Validating += new System.ComponentModel.CancelEventHandler(this.txtProcenat_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "(mjeseci)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "%";
            // 
            // dtpDatumPotpisivanja
            // 
            this.dtpDatumPotpisivanja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPotpisivanja.Location = new System.Drawing.Point(144, 75);
            this.dtpDatumPotpisivanja.Name = "dtpDatumPotpisivanja";
            this.dtpDatumPotpisivanja.Size = new System.Drawing.Size(148, 20);
            this.dtpDatumPotpisivanja.TabIndex = 11;
            // 
            // btnDodajUgovor
            // 
            this.btnDodajUgovor.Location = new System.Drawing.Point(341, 205);
            this.btnDodajUgovor.Name = "btnDodajUgovor";
            this.btnDodajUgovor.Size = new System.Drawing.Size(75, 23);
            this.btnDodajUgovor.TabIndex = 10;
            this.btnDodajUgovor.Text = "Dodaj";
            this.btnDodajUgovor.UseVisualStyleBackColor = true;
            this.btnDodajUgovor.Click += new System.EventHandler(this.btnDodajUgovor_Click);
            // 
            // txtUgovor
            // 
            this.txtUgovor.Location = new System.Drawing.Point(144, 207);
            this.txtUgovor.Name = "txtUgovor";
            this.txtUgovor.Size = new System.Drawing.Size(148, 20);
            this.txtUgovor.TabIndex = 9;
            this.txtUgovor.Validating += new System.ComponentModel.CancelEventHandler(this.txtUgovor_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ugovor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Procenat od prodaje";
            // 
            // txtTrajanjeUgovora
            // 
            this.txtTrajanjeUgovora.Location = new System.Drawing.Point(144, 121);
            this.txtTrajanjeUgovora.Name = "txtTrajanjeUgovora";
            this.txtTrajanjeUgovora.Size = new System.Drawing.Size(50, 20);
            this.txtTrajanjeUgovora.TabIndex = 5;
            this.txtTrajanjeUgovora.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrajanjeUgovora_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trajanje ugovora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum potpisivanja";
            // 
            // txtBrojUgovora
            // 
            this.txtBrojUgovora.Location = new System.Drawing.Point(144, 36);
            this.txtBrojUgovora.Name = "txtBrojUgovora";
            this.txtBrojUgovora.ReadOnly = true;
            this.txtBrojUgovora.Size = new System.Drawing.Size(148, 20);
            this.txtBrojUgovora.TabIndex = 1;
            this.txtBrojUgovora.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojUgovora_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj ugovora";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Naziv izdavača";
            // 
            // txtNazivIzdavaca
            // 
            this.txtNazivIzdavaca.Location = new System.Drawing.Point(145, 28);
            this.txtNazivIzdavaca.Name = "txtNazivIzdavaca";
            this.txtNazivIzdavaca.ReadOnly = true;
            this.txtNazivIzdavaca.Size = new System.Drawing.Size(148, 20);
            this.txtNazivIzdavaca.TabIndex = 41;
            this.txtNazivIzdavaca.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivIzdavaca_Validating);
            // 
            // btnPretragaIzdavaci
            // 
            this.btnPretragaIzdavaci.Location = new System.Drawing.Point(342, 26);
            this.btnPretragaIzdavaci.Name = "btnPretragaIzdavaci";
            this.btnPretragaIzdavaci.Size = new System.Drawing.Size(75, 23);
            this.btnPretragaIzdavaci.TabIndex = 42;
            this.btnPretragaIzdavaci.Text = "Pretraga";
            this.btnPretragaIzdavaci.UseVisualStyleBackColor = true;
            this.btnPretragaIzdavaci.Click += new System.EventHandler(this.btnPretragaIzdavaci_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPretragaIzdavaci);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtNazivIzdavaca);
            this.groupBox2.Location = new System.Drawing.Point(27, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 70);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odabir izdavača";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSnimi.Location = new System.Drawing.Point(210, 371);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 40);
            this.btnSnimi.TabIndex = 43;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmUgovoriAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 437);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUgovoriAdd";
            this.Text = "Dodavanje novog ugovora";
            this.Load += new System.EventHandler(this.frmUgovoriAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodajUgovor;
        private System.Windows.Forms.TextBox txtUgovor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrajanjeUgovora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojUgovora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNazivIzdavaca;
        private System.Windows.Forms.Button btnPretragaIzdavaci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDatumPotpisivanja;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtProcenat;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}