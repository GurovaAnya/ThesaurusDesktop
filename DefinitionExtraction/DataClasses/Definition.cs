using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionExtraction
{
    public class Definition
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public int StartLine { get; set; }
        public int StartChar { get; set; }
        public int EndLine { get; set; }
        public int EndChar { get; set; }
        public List<Link> Links {get;set;}

        public Definition()
        {

        }
    }
}
