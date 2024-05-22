using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDocument excelDoc = DocumentFactory.CreateDocument("excel");
            IDocument wordDoc = DocumentFactory.CreateDocument("word");
            IDocument pdfDoc = DocumentFactory.CreateDocument("pdf");

            excelDoc.GenerateDocument();
            wordDoc.GenerateDocument();
            pdfDoc.GenerateDocument();
            Console.ReadKey();

        }
    }
}
