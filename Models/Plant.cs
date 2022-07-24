using pronia.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pronia.Models
{
    public class Plant:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Desc { get; set; }
        public string SKU { get; set; }
        public int  PlantInformationId{ get; set; }
        public PlantInformation PlantInformation { get; set; }
        public List<PlantImage> PlantImages { get; set; }
        public List<PlantCategory> PlantCategories { get; set; }

    }
}
