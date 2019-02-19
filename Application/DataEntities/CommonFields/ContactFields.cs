using System.Collections.Generic;
using Utils.CoreUtilities;

namespace DataEntities.CommonFields
{
    public abstract class ContactFields : HelperFields
    {
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }

        public List<string> Telephones
        {
            get
            {
                var numbers = new List<string>();
                if (Telephone.IsNotEmpty())
                {
                    numbers.Add(Telephone);
                }
                if (Mobile.IsNotEmpty())
                {
                    numbers.Add(Mobile);
                }
                return numbers;
            }
        }
    }
}
