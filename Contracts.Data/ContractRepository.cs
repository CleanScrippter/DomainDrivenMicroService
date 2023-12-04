using Contracts.Data.Context;
using Contracts.Data.Model;
using Contracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Data
{
    public class ContractRepository : IContractRepository
    {
        private ContractDbContext _companyContext;

        public ContractRepository(ContractDbContext companyContext)
        {
            _companyContext = companyContext;
        }
        public ContractModel Get(int id)
        {
            
            ContractModel obj = new ContractModel();
            return _companyContext.Contracts.FirstOrDefault(s => s.CountryId == id);
        }

        public ProductModel GetProduct(int id)
        {

            ProductModel obj = new ProductModel();
            //return _companyContext.Contracts.FirstOrDefault(s => s.pro == id);
            return obj;
        }
    }
}
