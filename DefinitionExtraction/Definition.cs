using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionExtraction
{
    class Definition
    {
        public string Content { get; set; }
        public int StartLine { get; set; }
        public int StartChar { get; set; }
        public int EndLine { get; set; }
        public int EndChar { get; set; }

        public Definition()
        {

        }
    }
}
