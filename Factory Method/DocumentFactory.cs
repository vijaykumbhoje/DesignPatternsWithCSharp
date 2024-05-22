using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public static class DocumentFactory
    {
        public  static IDocument CreateDocument(string type)
        {
          switch(type.ToLower())
            {
                case "pdf":
                    return new PdfDocument();
                case "word":
                    return new WordDocument();
                case "excel":
                    return new ExcelDocument();
                default:
                    throw new ArgumentException("Invalid Document Type");
                        
            }               
        }
    }
}
