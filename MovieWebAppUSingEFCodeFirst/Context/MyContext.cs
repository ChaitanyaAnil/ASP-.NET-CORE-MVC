using MovieWebAppUSingEFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MovieWebAppUSingEFCodeFirst.Context
{
    public class MyContext:DbContext
    {
        public MyContext() : base("EFCmovieDb")
        { }
        public DbSet<Movie> Movies { get; set; }
       
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}