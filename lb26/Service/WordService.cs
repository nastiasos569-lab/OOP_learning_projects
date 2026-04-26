using lb26.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace lb26.Services
{
    public class WordService
    {
        private Word.Application app;
        private Word.Document doc;
        public List<string> CreatedDocuments { get; } = new List<string>();
        public Word.Document CurrentDocument => doc;
        public void OpenDocument(string path)
        {
            CloseDocumentIfOpen();
            app = new Word.Application();
            app.Visible = true;

            doc = app.Documents.Open(path);
        }
        public void CreateDocument(string templatePath)
        {
            app = new Word.Application();
            app.Visible = true;

            doc = app.Documents.Add(templatePath);

        }
        public void FillDocument(ReceiptData data)
        {
            Replace("<<Name>>", data.Name);
            Replace("<<Address>>", data.Address);
            Replace("<<Account>>", data.Account);
            Replace("<<Volume>>", data.Volume.ToString());
            Replace("<<Tariff>>", data.Tariff.ToString());
            Replace("<<Total>>", data.Total.ToString());
            Replace("<<Date>>", data.Date);
        }
        public void FindAndReplace(string find, string replace)
        {
            if (doc == null) return;

            app.Selection.Find.Execute(
                FindText: find,
                ReplaceWith: replace,
                Replace: Word.WdReplace.wdReplaceAll
            );
        }
        public void SaveAs(string path)
        {
            if (doc == null) return;

            doc.SaveAs2(path, Word.WdSaveFormat.wdFormatDocumentDefault);
            CreatedDocuments.Add(path);
        }
        public void OpenTemplate(string templatePath)
        {
            app = new Word.Application();
            app.Documents.Open(templatePath);
            app.Visible = true;
        }
        public void Close()
        {
            try
            {
                if (doc != null)
                {
                    doc.Close(false);
                }

                if (app != null)
                {
                    app.Quit();
                }
            }
            catch { }
        }
        private void Replace(string findText, string replaceText)
        {
            foreach (Word.Range range in doc.StoryRanges)
            {
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: findText, ReplaceWith: replaceText);
            }
        }
        public void SetActiveDocument(string path)
        {
            foreach (Word.Document d in app.Documents)
            {
                if (d.FullName == path)
                {
                    doc = d;
                    break;
                }
            }
        }
        public void CloseDocumentIfOpen()
        {
            try
            {
                if (doc != null)
                {
                    doc.Close(false);
                    doc = null;
                }

                if (app != null)
                {
                    if (app.Documents.Count == 0)
                    {
                        app.Quit();
                        app = null;
                    }
                }
            }
            catch { }
        }
    }
}