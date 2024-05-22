﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class WordDocument : IDocument
    {
        public void GenerateDocument()
        {
            Console.WriteLine("Creating Word Document");
        }
    }
}
