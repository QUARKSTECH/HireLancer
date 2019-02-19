using CommonObjects.Enums;
using System;

namespace DataEntities.CommonFields
{
    public abstract class PersonFields : ContactFields
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public GenderEnum Gender { get; set; }

        public DateTime? BirthDay { get; set; }

        public string BirthPlace { get; set; }

        public string Nationality { get; set; }

        public override string Display => FirstName + " " + LastName;
    }
}
