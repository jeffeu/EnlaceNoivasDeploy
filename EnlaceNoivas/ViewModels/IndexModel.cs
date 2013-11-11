using EnlaceNoivas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnlaceNoivas.ViewModels
{
    public class IndexModel
    {
        public IQueryable<PostBlog> Posts { get; set; }
        public IQueryable<Couple> TopCouples { get; set; }
    }
}