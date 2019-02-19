using CommonObjects.Enums;
using DataEntities.CommonFields;
using System.Collections.Generic;

namespace DataEntities.ERPEntities
{
    public class Role : HelperFields
    {
        public Role()
        {
            Users = new List<User>();
        }

        #region simple properties
        public string Name { get; set; }
        public RoleTypeEnum RoleType { get; set; }
        #endregion simple properties

        #region override properties
        public override string Display => Name;
        #endregion override properties

        #region Foreign Keys
        public virtual ICollection<User> Users { get; set; }
        #endregion Foreign Keys
    }
}