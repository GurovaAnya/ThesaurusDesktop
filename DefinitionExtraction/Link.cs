using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionExtraction
{
    public class Link
    {
        public int StartChar { get; set; }
        public int DescriptorID { get; set; }
        public string Descriptor { get; set; }

        public Link() { }

        public Link(int startChar, int descriptorID, string descriptor)
        {
            StartChar = startChar;
            DescriptorID = descriptorID;
            Descriptor = descriptor;
        }
    }
}
