using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        private IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }
        public void Add(Portfolio entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Portfolio entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Portfolio entity)
        {
            throw new NotImplementedException();
        }

        public List<Portfolio> GetList()
        {
            return _portfolioDal.GetList();
        }

        public Portfolio GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
