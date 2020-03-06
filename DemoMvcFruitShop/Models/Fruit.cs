using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DemoMvcFruitShop.Models
{
    public class Fruit
    {
        [Key]
        public int Fruit_id
        {
            get;set;
        }
        public string Fruit_Name { get; set; }
        public string Fruit_Type { get; set; }
        public double Price { get; set; }
    }
}
