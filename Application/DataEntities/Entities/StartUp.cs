using CommonObjects.Enum;
using DataEntities.Core;
using DataEntities.HelperField;

namespace DataEntities.Entities
{
    public class StartUp : HelperFields
    {
        public string VentureName { get; set; }
        public string InvestmentRequired { get; set; }
        public string Sector { get; set; }
        public string SubSector { get; set; }
        public string CurrentStage { get; set; }
        public string ExtraMessage { get; set; }
        public GetToKnow GetToKnow { get; set; }

        public long? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
