using DataEntities.Entities;
using DataEntities.HelperField;
using System.Collections.Generic;

namespace DataEntities.Core
{
    public class User : PersonFields
    {
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public string Currency { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public virtual ICollection<StartUp> StartUps { get; set; }
    }
}
