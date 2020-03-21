using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionExtraction
{
    public class Relation : IComparable<Relation>
    {
        int ID;
        public string Name { get; private set; }

        public Relation(int RelationID, string RelationName)
        {
            this.ID = RelationID;
            this.Name = RelationName;
        }

        public int CompareTo(Relation other)
        {
            return this.ID.CompareTo(other.ID);
        }
    }
}
