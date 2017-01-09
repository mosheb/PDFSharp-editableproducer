using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfDocument inputDocument = PdfReader.Open(@"C:\Users\moshe\Downloads\mikado.pdf", PdfDocumentOpenMode.Modify);
            inputDocument.Info.Producer = "moshe is producer";
            inputDocument.Info.Creator = "moshe is creator";
            inputDocument.Save(@"C:\Users\moshe\Downloads\mikado2.pdf");
        }
    }
}
