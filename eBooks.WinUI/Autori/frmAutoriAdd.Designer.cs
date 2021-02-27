namespace eBooks.WinUI.Autori
{
    partial class frmAutoriAdd
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
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.rtbBiografija = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPseudonim = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIme = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMjestoRodjenja = new System.Windows.Forms.ComboBox();
            this.cbDrzavaRodjenja = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.cbDrzavaSmrti = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumSmrti = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMjestoSmrti = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSnimi.Location = new System.Drawing.Point(341, 533);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 40);
            this.btnSnimi.TabIndex = 2;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(102, 60);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(178, 20);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // rtbBiografija
            // 
            this.rtbBiografija.Location = new System.Drawing.Point(129, 273);
            this.rtbBiografija.MaxLength = 2100;
            this.rtbBiografija.Name = "rtbBiografija";
            this.rtbBiografija.Size = new System.Drawing.Size(575, 184);
            this.rtbBiografija.TabIndex = 7;
            this.rtbBiografija.Text = "";
            this.rtbBiografija.Validating += new System.ComponentModel.CancelEventHandler(this.rtbBiografija_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pseudonim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kratka biografija";
            // 
            // txtPseudonim
            // 
            this.txtPseudonim.Location = new System.Drawing.Point(102, 95);
            this.txtPseudonim.Name = "txtPseudonim";
            this.txtPseudonim.Size = new System.Drawing.Size(178, 20);
            this.txtPseudonim.TabIndex = 5;
            this.txtPseudonim.Validating += new System.ComponentModel.CancelEventHandler(this.txtPseudonim_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(103, 25);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(178, 20);
            this.txtIme.TabIndex = 1;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMjestoRodjenja);
            this.groupBox1.Controls.Add(this.cbDrzavaRodjenja);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDatumRodjenja);
            this.groupBox1.Location = new System.Drawing.Point(5, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rođenje";
            // 
            // cbMjestoRodjenja
            // 
            this.cbMjestoRodjenja.FormattingEnabled = true;
            this.cbMjestoRodjenja.Location = new System.Drawing.Point(539, 20);
            this.cbMjestoRodjenja.Name = "cbMjestoRodjenja";
            this.cbMjestoRodjenja.Size = new System.Drawing.Size(160, 21);
            this.cbMjestoRodjenja.TabIndex = 5;
            // 
            // cbDrzavaRodjenja
            // 
            this.cbDrzavaRodjenja.FormattingEnabled = true;
            this.cbDrzavaRodjenja.Location = new System.Drawing.Point(285, 20);
            this.cbDrzavaRodjenja.Name = "cbDrzavaRodjenja";
            this.cbDrzavaRodjenja.Size = new System.Drawing.Size(160, 21);
            this.cbDrzavaRodjenja.TabIndex = 3;
            this.cbDrzavaRodjenja.SelectionChangeCommitted += new System.EventHandler(this.cbDrzavaRodjenja_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mjesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Država";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datum";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Checked = false;
            this.dtpDatumRodjenja.CustomFormat = " ";
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(97, 21);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.ShowCheckBox = true;
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(110, 20);
            this.dtpDatumRodjenja.TabIndex = 1;
            this.dtpDatumRodjenja.ValueChanged += new System.EventHandler(this.dtpDatumRodjenja_ValueChanged);
            // 
            // cbDrzavaSmrti
            // 
            this.cbDrzavaSmrti.FormattingEnabled = true;
            this.cbDrzavaSmrti.Location = new System.Drawing.Point(285, 18);
            this.cbDrzavaSmrti.Name = "cbDrzavaSmrti";
            this.cbDrzavaSmrti.Size = new System.Drawing.Size(160, 21);
            this.cbDrzavaSmrti.TabIndex = 3;
            this.cbDrzavaSmrti.SelectionChangeCommitted += new System.EventHandler(this.cbDrzavaSmrti_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mjesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Datum";
            // 
            // dtpDatumSmrti
            // 
            this.dtpDatumSmrti.Checked = false;
            this.dtpDatumSmrti.CustomFormat = " ";
            this.dtpDatumSmrti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumSmrti.Location = new System.Drawing.Point(98, 19);
            this.dtpDatumSmrti.Name = "dtpDatumSmrti";
            this.dtpDatumSmrti.ShowCheckBox = true;
            this.dtpDatumSmrti.Size = new System.Drawing.Size(110, 20);
            this.dtpDatumSmrti.TabIndex = 1;
            this.dtpDatumSmrti.ValueChanged += new System.EventHandler(this.dtpDatumSmrti_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Država";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpDatumSmrti);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbDrzavaSmrti);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbMjestoSmrti);
            this.groupBox2.Location = new System.Drawing.Point(5, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Smrt";
            // 
            // cbMjestoSmrti
            // 
            this.cbMjestoSmrti.FormattingEnabled = true;
            this.cbMjestoSmrti.Location = new System.Drawing.Point(539, 18);
            this.cbMjestoSmrti.Name = "cbMjestoSmrti";
            this.cbMjestoSmrti.Size = new System.Drawing.Size(160, 21);
            this.cbMjestoSmrti.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.txtIme);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPrezime);
            this.groupBox3.Controls.Add(this.rtbBiografija);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPseudonim);
            this.groupBox3.Location = new System.Drawing.Point(23, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 490);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o autoru";
            // 
            // frmAutoriAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 587);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmAutoriAdd";
            this.Text = "Dodavanje novog autora";
            this.Load += new System.EventHandler(this.frmAutoriAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.RichTextBox rtbBiografija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPseudonim;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumSmrti;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDrzavaSmrti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMjestoSmrti;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMjestoRodjenja;
        private System.Windows.Forms.ComboBox cbDrzavaRodjenja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
    }
}