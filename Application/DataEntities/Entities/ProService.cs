using DataEntities.HelperField;

namespace DataEntities.Entities
{
    public class ProService : HelperFields
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
    }
}
