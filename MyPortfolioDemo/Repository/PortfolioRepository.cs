using MyPortfolioDemo.Context;
using MyPortfolioDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolioDemo.Repository
{
    public class PortfolioRepository : IPortfolioRepository
    {
        private readonly MyPortfolioContext _db;
        public PortfolioRepository(MyPortfolioContext db)
        {
            _db = db;
        }
        public List<Portfolio> GetPortfolios()
        {
            return _db.Portfolios.ToList();
        }
    }
}
