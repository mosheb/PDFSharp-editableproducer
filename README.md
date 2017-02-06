# PDFSharp-editableproducer

allows clean producer and creator fields

Most pdf libraries insist on keeping control of what the creator and producer fields contain. The pdf spec implies no special treament of these fields. This fork has the minor patches that allow exact control of those fields. So the following will come out exactly as assigned:

        PdfDocument inputDocument = PdfReader.Open(@"C:\Users\joe\mikado.pdf", PdfDocumentOpenMode.Modify);
        inputDocument.Info.Producer = "I am the producer";
        inputDocument.Info.Creator = "I am the creator";
        inputDocument.Save(@"C:\Users\joe\mikado2.pdf");

Not to be used for removing other party's copyright notices etc such as that required by the lgpl vesion of itext.

Note that pdfsharp mangles unicode in the info object. You should encode first with something like this if unicode is used:

    private string PDFSharpEncodingHack(string str)
        {

            if (string.IsNullOrEmpty(str)) return "";

            var encoding = Encoding.BigEndianUnicode;
            var bytes = encoding.GetBytes(str);
            var sb = new StringBuilder();
            sb.Append((char)254);
            sb.Append((char)255);
            for (int i = 0; i < bytes.Length; ++i)
            {
                sb.Append((char)bytes[i]);
            }
            return sb.ToString();
        }

See Copyright notices preserved in code from Empira
