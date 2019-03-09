using DomainEntities.Core;
using System;

namespace DomainEntities.External
{
    public class ProServiceDto : HelperDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
    }
}
