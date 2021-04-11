using MyPortfolioDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolioDemo.Repository
{
    public interface IPortfolioRepository
    {
        List<Portfolio> GetPortfolios();
    }
}
