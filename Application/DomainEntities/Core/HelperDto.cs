using System;

namespace DomainEntities.Core
{
    public class HelperDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public bool Active { get; set; }
        public bool IsDraft { get; set; }
    }
}
