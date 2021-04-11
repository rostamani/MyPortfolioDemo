using Microsoft.EntityFrameworkCore;
using MyPortfolioDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolioDemo.Context
{
    public class MyPortfolioContext:DbContext
    {
        public MyPortfolioContext(DbContextOptions<MyPortfolioContext> options):base(options)
        {

        }

        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
