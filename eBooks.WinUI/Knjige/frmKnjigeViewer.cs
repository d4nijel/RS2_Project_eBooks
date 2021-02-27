using Patagames.Pdf.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Knjige
{
    public partial class frmKnjigeViewer : Form
    {
        private readonly APIService _knjigeServis = new APIService("knjige");
        private int? _id;
        public frmKnjigeViewer(int? knjigaId = null)
        {
            InitializeComponent();
            _id = knjigaId;
        }

        private async void frmKnjigeViewer_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var knjiga = await _knjigeServis.GetById<Model.Knjige>(_id);
                //Initialize the SDK library
                //You have to call this function before you can call any PDF processing functions.
                PdfCommon.Initialize();

                //Open and load a PDF document from a file.
                pdfViewer1.LoadDocument(knjiga.UzorakKnjige);
            }
        }
    }
}
