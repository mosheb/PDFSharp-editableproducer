# PDFSharp-editableproducer

allows clean producer and creator fields

Most pdf libraries for some reason insist on keeping control of what the creator and producer fields contain. Not sure why, the pdf spec implies no special treament of these fields. This fork has the minor patches that allow exact control of those fields. So the following will come out exactly as assigned:

        PdfDocument inputDocument = PdfReader.Open(@"C:\Users\joe\mikado.pdf", PdfDocumentOpenMode.Modify);
        inputDocument.Info.Producer = "I am the producer";
        inputDocument.Info.Creator = "I am the creator";
        inputDocument.Save(@"C:\Users\joe\mikado2.pdf");

Not to be used for removing other party's copywrite notices etc

