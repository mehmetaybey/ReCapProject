﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFrameWork
{
    public class ReCapContext:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\MSSQLLocalDB;Database=ReCapData;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
