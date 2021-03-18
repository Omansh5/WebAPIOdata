using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIConsumption.Models
{[Table("Product")]
    public class Product
    {[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Company { get; set; }
        public DateTime ManDate { get; set; }
        public DateTime ExpDate { get; set; }

    }
}