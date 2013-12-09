using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EnlaceNoivas.Models
{
    public class db : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Couple> Couple { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<PhotoOfProvider> PhotoOfProvider { get; set; }
        public DbSet<PostBlog> PostBlog { get; set; }
        public DbSet<EmailList> EmailList { get; set; }
        public DbSet<ProviderType> ProviderType { get; set; }
    }
}