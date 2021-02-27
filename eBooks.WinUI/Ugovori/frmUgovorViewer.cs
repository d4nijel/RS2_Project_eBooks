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

namespace eBooks.WinUI.Ugovori
{
    public partial class frmUgovorViewer : Form
    {
        private readonly APIService _ugovorService = new APIService("ugovori");
        private int? _id;
        public frmUgovorViewer(int? ugovorId = null)
        {
            InitializeComponent();
            _id = ugovorId;
        }

        private async void frmUgovorViewer_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var ugovor = await _ugovorService.GetById<Model.Ugovori>(_id);
                //Initialize the SDK library
                //You have to call this function before you can call any PDF processing functions.
                PdfCommon.Initialize();

                //Open and load a PDF document from a file.
                pdfViewer1.LoadDocument(ugovor.Ugovor);
            }
        }
    }
}
