using System;

namespace FactoryMethodPattern
{
    // Aryan Kumar Raj - 231fa18066
    
    // Abstract Product
    public abstract class Document
    {
        public abstract void Open();
    }

    // Concrete Products
    public class WordDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Word Document...");
        }
    }

    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening PDF Document...");
        }
    }

    public class ExcelDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Excel Document...");
        }
    }

    // Abstract Creator
    public abstract class DocumentFactory
    {
        public abstract Document CreateDocument();
    }

    // Concrete Creators
    public class WordDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new WordDocument();
        }
    }

    public class PdfDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new PdfDocument();
        }
    }

    public class ExcelDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new ExcelDocument();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Name: Aryan Kumar Raj");
            Console.WriteLine("Roll No: 231fa18066\n");

            DocumentFactory wordFactory = new WordDocumentFactory();
            Document wordDoc = wordFactory.CreateDocument();
            wordDoc.Open();

            DocumentFactory pdfFactory = new PdfDocumentFactory();
            Document pdfDoc = pdfFactory.CreateDocument();
            pdfDoc.Open();

            DocumentFactory excelFactory = new ExcelDocumentFactory();
            Document excelDoc = excelFactory.CreateDocument();
            excelDoc.Open();
        }
    }
}
