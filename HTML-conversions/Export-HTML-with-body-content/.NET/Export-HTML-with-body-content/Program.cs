﻿//Load an existing Word document.
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

using (FileStream fileStreamPath = new FileStream("Input.docx", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
{
    using (WordDocument document = new WordDocument(fileStreamPath, FormatType.Docx))
    {
        //Enable the flag, to save HTML with elements inside body tags alone.
        document.SaveOptions.HtmlExportBodyContentAlone = true;

        using (FileStream outputFileStream = new FileStream("WordToHTML.html", FileMode.Create, FileAccess.ReadWrite))
        {
            //Save Word document as HTML.
            document.Save(outputFileStream, FormatType.Html);
        }
    }
}
