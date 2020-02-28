using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieWebAppUSingEFCodeFirst.Models
{
    public class Multi
    {

        [key]
        public int MultiplexId { get; set; }
        public string MultiplexName { get; set; }



    }
}