using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.HelperField
{
    public class HelperFields
    {
        public HelperFields()
        {
            Active = true;
            IsDraft = false;
        }

        [Key]
        public long Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public bool Active { get; set; }
        public bool IsDraft { get; set; }

        public Guid ExternalID { get; set; }
    }
}
