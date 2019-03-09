using CommonObjects.Enum;
using DomainEntities.Core;

namespace DomainEntities.External
{
    public class StartUpDto : HelperDto
    {
        public string VentureName { get; set; }
        public string InvestmentRequired { get; set; }
        public string Sector { get; set; }
        public string SubSector { get; set; }
        public string CurrentStage { get; set; }
        public string ExtraMessage { get; set; }
        public GetToKnow GetToKnow { get; set; }
    }
}
