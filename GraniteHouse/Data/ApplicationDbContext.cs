﻿using System;
using System.Collections.Generic;
using System.Text;
using GraniteHouse.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GraniteHouse.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<SpecialTag> SpecialTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<ProdutSelectedForAppointment> ProdutSelectedForAppointment { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
