namespace eBooks.WinUI.Racuni
{
    partial class frmRacuniDetalji
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRacun = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivKnjige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRacunStavke = new System.Windows.Forms.DataGridView();
            this.txtIznosPDV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBrojRacuna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Prezime = new System.Windows.Forms.Label();
            this.txtDatumRacuna = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacunStavke)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRacun
            // 
            this.btnRacun.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRacun.Location = new System.Drawing.Point(148, 436);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(103, 42);
            this.btnRacun.TabIndex = 80;
            this.btnRacun.Text = "Ispis računa";
            this.btnRacun.UseVisualStyleBackColor = false;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Ukupan iznos računa sa PDV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Ukupan iznos računa";
            // 
            // txtIznos
            // 
            this.txtIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIznos.Location = new System.Drawing.Point(249, 350);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.ReadOnly = true;
            this.txtIznos.Size = new System.Drawing.Size(65, 20);
            this.txtIznos.TabIndex = 77;
            this.txtIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // NazivKnjige
            // 
            this.NazivKnjige.DataPropertyName = "Naziv";
            this.NazivKnjige.HeaderText = "Naziv knjige";
            this.NazivKnjige.Name = "NazivKnjige";
            this.NazivKnjige.ReadOnly = true;
            // 
            // dgvRacunStavke
            // 
            this.dgvRacunStavke.AllowUserToAddRows = false;
            this.dgvRacunStavke.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacunStavke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRacunStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacunStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivKnjige,
            this.ISBN,
            this.Cijena});
            this.dgvRacunStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacunStavke.Location = new System.Drawing.Point(3, 16);
            this.dgvRacunStavke.Name = "dgvRacunStavke";
            this.dgvRacunStavke.ReadOnly = true;
            this.dgvRacunStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacunStavke.Size = new System.Drawing.Size(349, 138);
            this.dgvRacunStavke.TabIndex = 0;
            // 
            // txtIznosPDV
            // 
            this.txtIznosPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIznosPDV.Location = new System.Drawing.Point(249, 391);
            this.txtIznosPDV.Name = "txtIznosPDV";
            this.txtIznosPDV.ReadOnly = true;
            this.txtIznosPDV.Size = new System.Drawing.Size(65, 20);
            this.txtIznosPDV.TabIndex = 79;
            this.txtIznosPDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRacunStavke);
            this.groupBox2.Location = new System.Drawing.Point(27, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 157);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke računa";
            // 
            // txtBrojRacuna
            // 
            this.txtBrojRacuna.Location = new System.Drawing.Point(121, 34);
            this.txtBrojRacuna.Name = "txtBrojRacuna";
            this.txtBrojRacuna.ReadOnly = true;
            this.txtBrojRacuna.Size = new System.Drawing.Size(176, 20);
            this.txtBrojRacuna.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Broj računa";
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
            // txtDatumRacuna
            // 
            this.txtDatumRacuna.Location = new System.Drawing.Point(121, 76);
            this.txtDatumRacuna.Name = "txtDatumRacuna";
            this.txtDatumRacuna.ReadOnly = true;
            this.txtDatumRacuna.Size = new System.Drawing.Size(176, 20);
            this.txtDatumRacuna.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBrojRacuna);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Prezime);
            this.groupBox1.Controls.Add(this.txtDatumRacuna);
            this.groupBox1.Location = new System.Drawing.Point(30, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 123);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o računu";
            // 
            // frmRacuniDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 509);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtIznosPDV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRacuniDetalji";
            this.Text = "Detalji računa";
            this.Load += new System.EventHandler(this.frmRacuniDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacunStavke)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivKnjige;
        private System.Windows.Forms.DataGridView dgvRacunStavke;
        private System.Windows.Forms.TextBox txtIznosPDV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBrojRacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.TextBox txtDatumRacuna;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}