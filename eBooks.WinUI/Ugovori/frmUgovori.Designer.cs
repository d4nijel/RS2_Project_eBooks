namespace eBooks.WinUI.Ugovori
{
    partial class frmUgovori
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.UgovorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojUgovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPotpisivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrajanjeUgovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtBrojUgovora = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.AllowUserToAddRows = false;
            this.dgvUgovori.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUgovori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UgovorID,
            this.BrojUgovora,
            this.DatumPotpisivanja,
            this.TrajanjeUgovora});
            this.dgvUgovori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUgovori.Location = new System.Drawing.Point(3, 16);
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.ReadOnly = true;
            this.dgvUgovori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUgovori.Size = new System.Drawing.Size(444, 217);
            this.dgvUgovori.TabIndex = 0;
            this.dgvUgovori.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUgovori_MouseDoubleClick);
            // 
            // UgovorID
            // 
            this.UgovorID.DataPropertyName = "UgovorID";
            this.UgovorID.HeaderText = "UgovorID";
            this.UgovorID.Name = "UgovorID";
            this.UgovorID.ReadOnly = true;
            this.UgovorID.Visible = false;
            // 
            // BrojUgovora
            // 
            this.BrojUgovora.DataPropertyName = "BrojUgovora";
            this.BrojUgovora.HeaderText = "Broj ugovora";
            this.BrojUgovora.Name = "BrojUgovora";
            this.BrojUgovora.ReadOnly = true;
            // 
            // DatumPotpisivanja
            // 
            this.DatumPotpisivanja.DataPropertyName = "DatumPotpisivanja";
            this.DatumPotpisivanja.HeaderText = "Datum potpisivanja";
            this.DatumPotpisivanja.Name = "DatumPotpisivanja";
            this.DatumPotpisivanja.ReadOnly = true;
            // 
            // TrajanjeUgovora
            // 
            this.TrajanjeUgovora.DataPropertyName = "TrajanjeUgovora";
            this.TrajanjeUgovora.HeaderText = "Trajanje ugovora";
            this.TrajanjeUgovora.Name = "TrajanjeUgovora";
            this.TrajanjeUgovora.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUgovori);
            this.groupBox1.Location = new System.Drawing.Point(29, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 236);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ugovori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Broj ugovora";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(338, 25);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 23);
            this.btnPrikazi.TabIndex = 7;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtBrojUgovora
            // 
            this.txtBrojUgovora.Location = new System.Drawing.Point(110, 27);
            this.txtBrojUgovora.Name = "txtBrojUgovora";
            this.txtBrojUgovora.Size = new System.Drawing.Size(176, 20);
            this.txtBrojUgovora.TabIndex = 2;
            this.txtBrojUgovora.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojUgovora_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnPrikazi);
            this.groupBox2.Controls.Add(this.txtBrojUgovora);
            this.groupBox2.Location = new System.Drawing.Point(29, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 65);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(29, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "* Dvostrukim klikom odaberite ugovor";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmUgovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 416);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmUgovori";
            this.Text = "Pretraga ugovora";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.DataGridViewTextBoxColumn UgovorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojUgovora;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPotpisivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrajanjeUgovora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtBrojUgovora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}