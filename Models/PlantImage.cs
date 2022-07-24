using pronia.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pronia.Models
{
    public class PlantImage:BaseEntity
    {
        public string Name { get; set; }
        public string Alternative { get; set; }
        public bool? IsMain { get; set; }
        public int PlantId { get; set; }
        public Plant Plant { get; set; }
    }
}
