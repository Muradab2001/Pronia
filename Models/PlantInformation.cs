using pronia.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pronia.Models
{
    public class PlantInformation:BaseEntity
    {
        public string Shipping { get; set; }
        public string AboutReturnRequst { get; set; }
        public string Guarentee { get; set; }
        public List<Plant> Plants { get; set; }
    }
}
