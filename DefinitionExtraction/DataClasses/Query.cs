using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionExtraction
{
    class Query
    {
        private DateTime toDate;

        public int RelatedDescriptorID { get; set; } = -1;
        public int RelationID { get; set; } = -1;

        public bool UserAdded { get; set; }
        public bool TimeAdded { get; set; }
        public DateTime FromDate { get; set; }
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

        public Query(int relatedDescriptor, int relationType, bool userAdded, DateTime fromDate, DateTime toDate)
        {
            this.RelatedDescriptorID = relatedDescriptor;
            this.RelationID = relationType;
            this.UserAdded = userAdded;
            this.FromDate = fromDate;
            this.ToDate = toDate;
        }

        public Query(int relatedDescriptor, int relationType, bool userAdded)
        {
            this.RelatedDescriptorID = relatedDescriptor;
            this.RelationID = relationType;
            this.UserAdded = userAdded;
        }
    }
}
