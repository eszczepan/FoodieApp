using FoodieApp.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodieApp.Data
{
    public class FoodieAppDbContext : DbContext
    {
        public FoodieAppDbContext(DbContextOptions<FoodieAppDbContext> options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
