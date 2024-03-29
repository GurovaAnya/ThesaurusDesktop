﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionExtraction
{
    public class Termin
    {
        public int ID { get; set; }
        public string Descriptor { get;  set; }
        public string Relator { get; set; }
        public List<Definition> Definitions { get; set; } = new List<Definition>();
        public int StartLine { get; set; }
        public int StartChar { get; set; }
        public int EndLine { get; set; }
        public int EndChar { get; set; }
        public List<string> Ascriptors { get; set; } = new List<string>();
        public RelationsList Relations { get; set; }
        

        public Termin()
        {

        }

        public Termin(string descriptor, string relator, int sL, int sC, int eL, int eC)
        {
            Descriptor = descriptor;
            Relator = relator;
            StartLine = sL;
            StartChar = sC;
            EndLine = eL;
            EndChar = eC;
        }
    }
}
