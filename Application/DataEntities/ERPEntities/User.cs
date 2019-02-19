using DataEntities.CommonFields;
using System;
using System.Collections.Generic;

namespace DataEntities.ERPEntities
{
    public class User : PersonFields
    {
        public User()
        {
        }

        #region simple properties
        public string Password { get; set; }
        public string TempPassword { get; set; }
        public bool ChangePassword { get; set; }
        public DateTime? PasswordResetDate { get; set; }

        public bool ActiveInUserBase { get; set; }

        public int FailedLoginCount { get; set; }

        public DateTime? LastActive { get; set; }

        public DateTime? ExpirationDate { get; set; }
        #endregion simple properties


        #region Foreign Keys

        public long? RoleId { get; set; }
        public virtual Role Role { get; set; }
        #endregion Foreign Keys
    }
}
