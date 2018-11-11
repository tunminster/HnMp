using HnMp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Common;


namespace HnMp.Database
{
    public class HnMpDatabase : DbContext
    {
        public HnMpDatabase() { }
        public HnMpDatabase(DbContextOptions options) : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
