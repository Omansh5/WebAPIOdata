﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIConsumption.Data
{
    public class ProductDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProductDbContext() : base("name=ProductDbContext")
        {
        }

        public System.Data.Entity.DbSet<WebAPIConsumption.Models.Product> Products { get; set; }
    }
}