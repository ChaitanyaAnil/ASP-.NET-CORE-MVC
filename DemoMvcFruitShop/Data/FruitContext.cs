using DemoMvcFruitShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvcFruitShop.Context
{
    public class FruitContext:DbContext
    {
        public FruitContext(DbContextOptions<FruitContext> options) : base(options)
        {

        }
        public DbSet<Fruit> Fruits { get; set; }
    }
}
