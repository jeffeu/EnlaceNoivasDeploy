﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EnlaceNoivas.Models
{
    public class dbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Couple> Couple { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<PhotoOfProvider> PhotoOfProvider { get; set; }
        public DbSet<PostBlog> PostBlog { get; set; }
    }
}