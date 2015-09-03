﻿using System.Data.Entity;

namespace PhotoFundao.Models
{
    public class PhotoFundaoContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}