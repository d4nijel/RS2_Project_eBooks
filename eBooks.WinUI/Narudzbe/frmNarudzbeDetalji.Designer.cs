namespace eBooks.WinUI.Narudzbe
{
    partial class frmNarudzbeDetalji
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOtkazano = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.txtBrojNarudzbe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Prezime = new System.Windows.Forms.Label();
            this.txtDatumNarudzbe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNarudzbeStavke = new System.Windows.Forms.DataGridView();
            this.NazivKnjige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIznosPDV = new System.Windows.Forms.TextBox();
            this.btnNarudzba = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbeStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOtkazano);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.txtBrojNarudzbe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Prezime);
            this.groupBox1.Controls.Add(this.txtDatumNarudzbe);
            this.groupBox1.Location = new System.Drawing.Point(30, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 194);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o narudžbi";
            // 
            // cbOtkazano
            // 
            this.cbOtkazano.AutoCheck = false;
            this.cbOtkazano.AutoSize = true;
            this.cbOtkazano.Location = new System.Drawing.Point(121, 160);
            this.cbOtkazano.Name = "cbOtkazano";
            this.cbOtkazano.Size = new System.Drawing.Size(72, 17);
            this.cbOtkazano.TabIndex = 66;
            this.cbOtkazano.Text = "Otkazano";
            this.cbOtkazano.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Otkazano";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoCheck = false;
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(121, 115);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(65, 17);
            this.cbStatus.TabIndex = 62;
            this.cbStatus.Text = "Plaćeno";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // txtBrojNarudzbe
            // 
            this.txtBrojNarudzbe.Location = new System.Drawing.Point(121, 34);
            this.txtBrojNarudzbe.Name = "txtBrojNarudzbe";
            this.txtBrojNarudzbe.ReadOnly = true;
            this.txtBrojNarudzbe.Size = new System.Drawing.Size(176, 20);
            this.txtBrojNarudzbe.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Broj narudžbe";
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(24, 79);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(38, 13);
            this.Prezime.TabIndex = 35;
            this.Prezime.Text = "Datum";
            // 
            // txtDatumNarudzbe
            // 
            this.txtDatumNarudzbe.Location = new System.Drawing.Point(121, 76);
            this.txtDatumNarudzbe.Name = "txtDatumNarudzbe";
            this.txtDatumNarudzbe.ReadOnly = true;
            this.txtDatumNarudzbe.Size = new System.Drawing.Size(176, 20);
            this.txtDatumNarudzbe.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNarudzbeStavke);
            this.groupBox2.Location = new System.Drawing.Point(30, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 157);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke narudžbe";
            // 
            // dgvNarudzbeStavke
            // 
            this.dgvNarudzbeStavke.AllowUserToAddRows = false;
            this.dgvNarudzbeStavke.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbeStavke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNarudzbeStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbeStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivKnjige,
            this.ISBN,
            this.Cijena});
            this.dgvNarudzbeStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNarudzbeStavke.Location = new System.Drawing.Point(3, 16);
            this.dgvNarudzbeStavke.Name = "dgvNarudzbeStavke";
            this.dgvNarudzbeStavke.ReadOnly = true;
            this.dgvNarudzbeStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbeStavke.Size = new System.Drawing.Size(349, 138);
            this.dgvNarudzbeStavke.TabIndex = 0;
            // 
            // NazivKnjige
            // 
            this.NazivKnjige.DataPropertyName = "Naziv";
            this.NazivKnjige.HeaderText = "Naziv knjige";
            this.NazivKnjige.Name = "NazivKnjige";
            this.NazivKnjige.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Ukupan iznos narudžbe";
            // 
            // txtIznos
            // 
            this.txtIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIznos.Location = new System.Drawing.Point(252, 420);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.ReadOnly = true;
            this.txtIznos.Size = new System.Drawing.Size(65, 20);
            this.txtIznos.TabIndex = 70;
            this.txtIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Ukupan iznos narudžbe sa PDV";
            // 
            // txtIznosPDV
            // 
            this.txtIznosPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIznosPDV.Location = new System.Drawing.Point(252, 461);
            this.txtIznosPDV.Name = "txtIznosPDV";
            this.txtIznosPDV.ReadOnly = true;
            this.txtIznosPDV.Size = new System.Drawing.Size(65, 20);
            this.txtIznosPDV.TabIndex = 72;
            this.txtIznosPDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNarudzba
            // 
            this.btnNarudzba.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNarudzba.Location = new System.Drawing.Point(151, 506);
            this.btnNarudzba.Name = "btnNarudzba";
            this.btnNarudzba.Size = new System.Drawing.Size(103, 42);
            this.btnNarudzba.TabIndex = 73;
            this.btnNarudzba.Text = "Ispis narudžbe";
            this.btnNarudzba.UseVisualStyleBackColor = false;
            this.btnNarudzba.Click += new System.EventHandler(this.btnNarudzba_Click);
            // 
            // frmNarudzbeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 561);
            this.Controls.Add(this.btnNarudzba);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIznosPDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNarudzbeDetalji";
            this.Text = "Detalji narudžbe";
            this.Load += new System.EventHandler(this.frmNarudzbeDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbeStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojNarudzbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.TextBox txtDatumNarudzbe;
        private System.Windows.Forms.CheckBox cbOtkazano;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNarudzbeStavke;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIznosPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivKnjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.Button btnNarudzba;
    }
}