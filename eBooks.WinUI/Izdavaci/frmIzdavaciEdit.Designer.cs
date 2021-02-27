namespace eBooks.WinUI.Izdavaci
{
    partial class frmIzdavaciEdit
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGrad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDrzava = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtKontaktTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtKontaktEmail = new System.Windows.Forms.TextBox();
            this.txtKontaktOsoba = new System.Windows.Forms.TextBox();
            this.txtGodinaOsnivanja = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSnimi.Location = new System.Drawing.Point(260, 331);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 40);
            this.btnSnimi.TabIndex = 16;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kontakt telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kontakt osoba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Godina osnivanja";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(181, 29);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(150, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // cbGrad
            // 
            this.cbGrad.FormattingEnabled = true;
            this.cbGrad.Location = new System.Drawing.Point(338, 22);
            this.cbGrad.Name = "cbGrad";
            this.cbGrad.Size = new System.Drawing.Size(160, 21);
            this.cbGrad.TabIndex = 19;
            this.cbGrad.Validating += new System.ComponentModel.CancelEventHandler(this.cbGrad_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Država";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kontakt email";
            // 
            // cbDrzava
            // 
            this.cbDrzava.FormattingEnabled = true;
            this.cbDrzava.Location = new System.Drawing.Point(84, 22);
            this.cbDrzava.Name = "cbDrzava";
            this.cbDrzava.Size = new System.Drawing.Size(160, 21);
            this.cbDrzava.TabIndex = 20;
            this.cbDrzava.SelectionChangeCommitted += new System.EventHandler(this.cbDrzava_SelectionChangeCommitted);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtKontaktTelefon
            // 
            this.txtKontaktTelefon.Location = new System.Drawing.Point(181, 139);
            this.txtKontaktTelefon.Mask = "+999 (00) 000-000";
            this.txtKontaktTelefon.Name = "txtKontaktTelefon";
            this.txtKontaktTelefon.Size = new System.Drawing.Size(150, 20);
            this.txtKontaktTelefon.TabIndex = 31;
            this.txtKontaktTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtKontaktTelefon_Validating);
            // 
            // txtKontaktEmail
            // 
            this.txtKontaktEmail.Location = new System.Drawing.Point(181, 174);
            this.txtKontaktEmail.Name = "txtKontaktEmail";
            this.txtKontaktEmail.Size = new System.Drawing.Size(150, 20);
            this.txtKontaktEmail.TabIndex = 13;
            this.txtKontaktEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtKontaktEmail_Validating);
            // 
            // txtKontaktOsoba
            // 
            this.txtKontaktOsoba.Location = new System.Drawing.Point(181, 102);
            this.txtKontaktOsoba.Name = "txtKontaktOsoba";
            this.txtKontaktOsoba.Size = new System.Drawing.Size(150, 20);
            this.txtKontaktOsoba.TabIndex = 11;
            this.txtKontaktOsoba.Validating += new System.ComponentModel.CancelEventHandler(this.txtKontaktOsoba_Validating);
            // 
            // txtGodinaOsnivanja
            // 
            this.txtGodinaOsnivanja.Location = new System.Drawing.Point(181, 65);
            this.txtGodinaOsnivanja.Name = "txtGodinaOsnivanja";
            this.txtGodinaOsnivanja.Size = new System.Drawing.Size(150, 20);
            this.txtGodinaOsnivanja.TabIndex = 10;
            this.txtGodinaOsnivanja.Validating += new System.ComponentModel.CancelEventHandler(this.txtGodinaOsnivanja_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGrad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbDrzava);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 59);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sjedište";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Mjesto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbStatus);
            this.groupBox1.Controls.Add(this.txtKontaktTelefon);
            this.groupBox1.Controls.Add(this.txtKontaktEmail);
            this.groupBox1.Controls.Add(this.txtKontaktOsoba);
            this.groupBox1.Controls.Add(this.txtGodinaOsnivanja);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 285);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izdavač";
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Location = new System.Drawing.Point(442, 31);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(62, 17);
            this.chbStatus.TabIndex = 17;
            this.chbStatus.Text = "Aktivan";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // frmIzdavaciEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 396);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIzdavaciEdit";
            this.Text = "Pregled i izmjena podataka o izdavaču";
            this.Load += new System.EventHandler(this.frmIzdavaciEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGrad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDrzava;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtKontaktTelefon;
        private System.Windows.Forms.TextBox txtKontaktEmail;
        private System.Windows.Forms.TextBox txtKontaktOsoba;
        private System.Windows.Forms.TextBox txtGodinaOsnivanja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbStatus;
    }
}