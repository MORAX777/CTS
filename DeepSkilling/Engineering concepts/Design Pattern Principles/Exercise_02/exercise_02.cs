using System;

namespace FactoryMethodPatternExample
{
    
    interface IDocument
    {
        void Open();
        void Save();
    }


    class WordDocument : IDocument
    {
        public void Open()  { Console.WriteLine("Opening Word document (.docx)"); }
        public void Save()  { Console.WriteLine("Saving Word document (.docx)"); }
    }

    class PdfDocument : IDocument
    {
        public void Open()  { Console.WriteLine("Opening PDF document (.pdf)"); }
        public void Save()  { Console.WriteLine("Saving PDF document (.pdf)"); }
    }

    class ExcelDocument : IDocument
    {
        public void Open()  { Console.WriteLine("Opening Excel document (.xlsx)"); }
        public void Save()  { Console.WriteLine("Saving Excel document (.xlsx)"); }
    }

   
    abstract class DocumentFactory
    {
        
        public abstract IDocument CreateDocument();

        
        public void OpenAndSave()
        {
            IDocument doc = CreateDocument();
            doc.Open();
            doc.Save();
        }
    }

    
    class WordDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }

    class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }

    class ExcelDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method Pattern - Document Management\n");

            DocumentFactory factory;

            Console.WriteLine(" Word Document");
            factory = new WordDocumentFactory();
            factory.OpenAndSave();

            Console.WriteLine("\n PDF Document ");
            factory = new PdfDocumentFactory();
            factory.OpenAndSave();

            Console.WriteLine("\n Excel Document ");
            factory = new ExcelDocumentFactory();
            factory.OpenAndSave();
        }
    }
}
