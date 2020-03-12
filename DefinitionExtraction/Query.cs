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
        private string relationType;
        private DateTime toDate;

        public ObjectType ObjectType;

        public string RelatedDescriptor { get; set; }     
        public string RelationType
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
                    relationType = null;
            }
        }
        public bool UserAdded;
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
            }
        }

        public Query(ObjectType ot, string relatedDescriptor, string RelationType, bool userAdded, DateTime fromDate, DateTime toDate)
        {
            this.ObjectType = ot;
            this.RelatedDescriptor = relatedDescriptor;
            this.UserAdded = userAdded;
            this.FromDate = fromDate;
            this.ToDate = toDate;
        }

        public Query(ObjectType ot, string relatedDescriptor, string RelationType, bool userAdded)
        {
            this.ObjectType = ot;
            this.RelatedDescriptor = relatedDescriptor;
            this.UserAdded = userAdded;
        }
    }
}
