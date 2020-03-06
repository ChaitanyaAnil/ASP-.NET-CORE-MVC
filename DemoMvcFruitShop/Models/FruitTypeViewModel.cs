using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvcFruitShop.Models
{
    public class FruitTypeViewModel
    {
        public List<Fruit> Fruits { get; set; }
        public SelectList Colors { get; set; }
        public string FruitColor { get; set; }
        public string Searchstr { get; set; }
    }
}
