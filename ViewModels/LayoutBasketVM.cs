using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pronia.ViewModels
{
    public class LayoutBasketVM
    {
        public List<BasketItemVM> BasketItemVMs { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
