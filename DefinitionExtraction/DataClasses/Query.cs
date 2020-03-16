using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionExtraction
{
    public enum ObjectType {Дескриптор=0, Аскриптор=1, Определение=2, Связь=3};
    class Query
    {
        private int relationType;
        private DateTime toDate;

        public ObjectType ObjectType;

        public int RelatedDescriptorID { get; set; } = -1;   
        public int RelationID
        {
            get
            {
                return relationType; 
            }
            set
            {
                if (ObjectType == ObjectType.Дескриптор)
                    relationType = value;
                else
                    relationType = -1;
            }
        }
        public bool UserAdded;
        public bool TimeAdded;
        public DateTime FromDate;
        public DateTime ToDate
        {
            get
            {
                return toDate;
            }
            set
            {
                if (value >= FromDate)
                    toDate = value;
                else toDate = FromDate;
                TimeAdded = true;
            }
        }

        public Query(ObjectType ot, int relatedDescriptor, int RelationType, bool userAdded, DateTime fromDate, DateTime toDate)
        {
            this.ObjectType = ot;
            this.RelatedDescriptorID = relatedDescriptor;
            this.RelationID = relationType;
            this.UserAdded = userAdded;
            this.FromDate = fromDate;
            this.ToDate = toDate;
        }

        public Query(ObjectType ot, int relatedDescriptor, int relationType, bool userAdded)
        {
            this.ObjectType = ot;
            this.RelatedDescriptorID = relatedDescriptor;
            this.RelationID = relationType;
            this.UserAdded = userAdded;
        }
    }
}
