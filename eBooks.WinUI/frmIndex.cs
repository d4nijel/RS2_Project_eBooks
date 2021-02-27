using eBooks.WinUI.Autori;
using eBooks.WinUI.Izdavaci;
using eBooks.WinUI.Knjige;
using eBooks.WinUI.Kolekcije;
using eBooks.WinUI.Korisnici;
using eBooks.WinUI.Kupci;
using eBooks.WinUI.Narudzbe;
using eBooks.WinUI.Racuni;
using eBooks.WinUI.Ugovori;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();
            frm.Show();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisniciAdd frm = new frmKorisniciAdd();
            frm.Show();
        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAutori frm = new frmAutori();
            frm.Show();
        }

        private void noviAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutoriAdd frm = new frmAutoriAdd();
            frm.Show();
        }

        private void novaKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKnjigeAdd frm = new frmKnjigeAdd();
            frm.Show();
        }

        private void dodavanjeKolekcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKolekcijeAdd frm = new frmKolekcijeAdd();
            frm.Show();
        }

        private void pregledKolekcijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKolekcije frm = new frmKolekcije();
            frm.Show();
        }

        private void dodajIzdavačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzdavaciAdd frm = new frmIzdavaciAdd();
            frm.Show();
        }

        private void pregledIzdavačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzdavaci frm = new frmIzdavaci();
            frm.Show();
        }

        private void noviUgovorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUgovoriAdd frm = new frmUgovoriAdd();
            frm.Show();
        }

        private void pregledUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUgovori frm = new frmUgovori();
            frm.Show();
        }

        private void pretragaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmKnjige frm = new frmKnjige();
            frm.Show();
        }

        private void pregledKupacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKupci frm = new frmKupci();
            frm.Show();
        }

        private void pregledNarudžbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNarudzbe frm = new frmNarudzbe();
            frm.Show();
        }

        private void pregledRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRacuni frm = new frmRacuni();
            frm.Show();
        }
    }
}
