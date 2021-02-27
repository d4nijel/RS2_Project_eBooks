namespace eBooks.WinUI
{
    partial class frmIndex
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKolekcijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeKolekcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izdavačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledIzdavačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajIzdavačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugovoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledUgovoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviUgovorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKupacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledNarudžbiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.autoriToolStripMenuItem,
            this.knjigeToolStripMenuItem,
            this.izdavačiToolStripMenuItem,
            this.ugovoriToolStripMenuItem,
            this.izvještajiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // autoriToolStripMenuItem
            // 
            this.autoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1,
            this.noviAutorToolStripMenuItem});
            this.autoriToolStripMenuItem.Name = "autoriToolStripMenuItem";
            this.autoriToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.autoriToolStripMenuItem.Text = "Autori";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.pretragaToolStripMenuItem1_Click);
            // 
            // noviAutorToolStripMenuItem
            // 
            this.noviAutorToolStripMenuItem.Name = "noviAutorToolStripMenuItem";
            this.noviAutorToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.noviAutorToolStripMenuItem.Text = "Novi autor";
            this.noviAutorToolStripMenuItem.Click += new System.EventHandler(this.noviAutorToolStripMenuItem_Click);
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem2,
            this.novaKnjigaToolStripMenuItem,
            this.pregledKolekcijaToolStripMenuItem,
            this.dodavanjeKolekcijeToolStripMenuItem});
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // pretragaToolStripMenuItem2
            // 
            this.pretragaToolStripMenuItem2.Name = "pretragaToolStripMenuItem2";
            this.pretragaToolStripMenuItem2.Size = new System.Drawing.Size(167, 22);
            this.pretragaToolStripMenuItem2.Text = "Pretraga";
            this.pretragaToolStripMenuItem2.Click += new System.EventHandler(this.pretragaToolStripMenuItem2_Click);
            // 
            // novaKnjigaToolStripMenuItem
            // 
            this.novaKnjigaToolStripMenuItem.Name = "novaKnjigaToolStripMenuItem";
            this.novaKnjigaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.novaKnjigaToolStripMenuItem.Text = "Nova knjiga";
            this.novaKnjigaToolStripMenuItem.Click += new System.EventHandler(this.novaKnjigaToolStripMenuItem_Click);
            // 
            // pregledKolekcijaToolStripMenuItem
            // 
            this.pregledKolekcijaToolStripMenuItem.Name = "pregledKolekcijaToolStripMenuItem";
            this.pregledKolekcijaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pregledKolekcijaToolStripMenuItem.Text = "Pretraga kolekcija";
            this.pregledKolekcijaToolStripMenuItem.Click += new System.EventHandler(this.pregledKolekcijaToolStripMenuItem_Click);
            // 
            // dodavanjeKolekcijeToolStripMenuItem
            // 
            this.dodavanjeKolekcijeToolStripMenuItem.Name = "dodavanjeKolekcijeToolStripMenuItem";
            this.dodavanjeKolekcijeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.dodavanjeKolekcijeToolStripMenuItem.Text = "Nova kolekcija";
            this.dodavanjeKolekcijeToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeKolekcijeToolStripMenuItem_Click);
            // 
            // izdavačiToolStripMenuItem
            // 
            this.izdavačiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledIzdavačaToolStripMenuItem,
            this.dodajIzdavačaToolStripMenuItem});
            this.izdavačiToolStripMenuItem.Name = "izdavačiToolStripMenuItem";
            this.izdavačiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.izdavačiToolStripMenuItem.Text = "Izdavači";
            // 
            // pregledIzdavačaToolStripMenuItem
            // 
            this.pregledIzdavačaToolStripMenuItem.Name = "pregledIzdavačaToolStripMenuItem";
            this.pregledIzdavačaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pregledIzdavačaToolStripMenuItem.Text = "Pretraga";
            this.pregledIzdavačaToolStripMenuItem.Click += new System.EventHandler(this.pregledIzdavačaToolStripMenuItem_Click);
            // 
            // dodajIzdavačaToolStripMenuItem
            // 
            this.dodajIzdavačaToolStripMenuItem.Name = "dodajIzdavačaToolStripMenuItem";
            this.dodajIzdavačaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.dodajIzdavačaToolStripMenuItem.Text = "Novi izdavač";
            this.dodajIzdavačaToolStripMenuItem.Click += new System.EventHandler(this.dodajIzdavačaToolStripMenuItem_Click);
            // 
            // ugovoriToolStripMenuItem
            // 
            this.ugovoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledUgovoraToolStripMenuItem,
            this.noviUgovorToolStripMenuItem});
            this.ugovoriToolStripMenuItem.Name = "ugovoriToolStripMenuItem";
            this.ugovoriToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ugovoriToolStripMenuItem.Text = "Ugovori";
            // 
            // pregledUgovoraToolStripMenuItem
            // 
            this.pregledUgovoraToolStripMenuItem.Name = "pregledUgovoraToolStripMenuItem";
            this.pregledUgovoraToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pregledUgovoraToolStripMenuItem.Text = "Pretraga";
            this.pregledUgovoraToolStripMenuItem.Click += new System.EventHandler(this.pregledUgovoraToolStripMenuItem_Click);
            // 
            // noviUgovorToolStripMenuItem
            // 
            this.noviUgovorToolStripMenuItem.Name = "noviUgovorToolStripMenuItem";
            this.noviUgovorToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.noviUgovorToolStripMenuItem.Text = "Novi ugovor";
            this.noviUgovorToolStripMenuItem.Click += new System.EventHandler(this.noviUgovorToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKupacaToolStripMenuItem,
            this.pregledNarudžbiToolStripMenuItem,
            this.pregledRačunaToolStripMenuItem});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // pregledKupacaToolStripMenuItem
            // 
            this.pregledKupacaToolStripMenuItem.Name = "pregledKupacaToolStripMenuItem";
            this.pregledKupacaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pregledKupacaToolStripMenuItem.Text = "Pregled kupaca";
            this.pregledKupacaToolStripMenuItem.Click += new System.EventHandler(this.pregledKupacaToolStripMenuItem_Click);
            // 
            // pregledNarudžbiToolStripMenuItem
            // 
            this.pregledNarudžbiToolStripMenuItem.Name = "pregledNarudžbiToolStripMenuItem";
            this.pregledNarudžbiToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pregledNarudžbiToolStripMenuItem.Text = "Pregled narudžbi";
            this.pregledNarudžbiToolStripMenuItem.Click += new System.EventHandler(this.pregledNarudžbiToolStripMenuItem_Click);
            // 
            // pregledRačunaToolStripMenuItem
            // 
            this.pregledRačunaToolStripMenuItem.Name = "pregledRačunaToolStripMenuItem";
            this.pregledRačunaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pregledRačunaToolStripMenuItem.Text = "Pregled računa";
            this.pregledRačunaToolStripMenuItem.Click += new System.EventHandler(this.pregledRačunaToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = ".:eBooks:.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeKolekcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKolekcijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izdavačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajIzdavačaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledIzdavačaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugovoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviUgovorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledUgovoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKupacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledNarudžbiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledRačunaToolStripMenuItem;
    }
}



