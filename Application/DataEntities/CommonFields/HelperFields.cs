using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Utils.CoreUtilities;

namespace DataEntities.CommonFields
{
    public abstract class HelperFields
    {
        protected HelperFields()
        {
            Active = true;
            CreatedOn = DateTime.UtcNow;
            ExternalId = Guid.NewGuid();
        }

        public long Id { get; set; }

        public long? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public bool Active { get; set; }
        public bool IsDraft { get; set; }

        public string Memo { get; set; }

        public Guid ExternalId { get; set; }

        public string ExternalReference { get; set; }

        [NotMapped]
        public abstract string Display { get; }

        [NotMapped]
        private string _extraProperties { get; set; }

        public string ExtraProperties
        {
            get
            {
                if (_extraProps != null && !PreventAutoUpdateExtraProps)
                {
                    _extraProperties = _extraProps.SerializeDictionary();
                }
                return _extraProperties;
            }
            set { _extraProperties = value; }
        }

        [NotMapped]
        private bool PreventAutoUpdateExtraProps { get; set; }


        [NotMapped]
        private Dictionary<string, object> _extraProps { get; set; }

        [NotMapped]
        public Dictionary<string, object> ExtraProps
        {
            get
            {
                if (_extraProps == null)
                {
                    _extraProps = ExtraProperties.DeserializeDictionary();
                }

                return _extraProps;
            }
            set
            {
                _extraProps = value;
            }
        }
    }
}
