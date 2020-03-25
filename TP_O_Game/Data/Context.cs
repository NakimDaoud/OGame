﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP_O_Game.Data
{
    public class Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Context() : base("name=Context")
        {
        }

        public System.Data.Entity.DbSet<BO_O_Game.Planet> Planets { get; set; }

        public System.Data.Entity.DbSet<BO_O_Game.Resource> Resources { get; set; }

        public System.Data.Entity.DbSet<BO_O_Game.SolarSystem> SolarSystems { get; set; }
    }
}