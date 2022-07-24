using pronia.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pronia.Models
{
    public class Category:BaseEntity
    {
        public int Name { get; set; }
        public List<PlantCategory> PlantCategories { get; set; }
    }
}
