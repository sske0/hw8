﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    public class ProDocumentProgram : DocumentProgram
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited");

        }
        public override void SaveDocument() 
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");

        }

    }
}
