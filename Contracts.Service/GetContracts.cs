using AutoMapper;
using Contracts.Data;
using Contracts.Data.Context;
using Contracts.Data.Model;
using Contracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Service
{
    public class GetContracts : IGetContracts
    {
        private IContractRepository _companyContext;
        private readonly IMapper _mapper;
        public GetContracts(IContractRepository companyContext, IMapper mapper)
        {
            _companyContext = companyContext;
            _mapper = mapper;
        }

        public Contract GetActiveContracts(int countryId)
        {
          ContractModel contractList = new ContractModel();
            IEnumerable <Contract> obj = new List<Contract>();
           
            contractList = _companyContext.Get(countryId);
          
            var employeeViewModel = _mapper.Map<Contract>(contractList);
            return employeeViewModel;

            //List<Contract> obj = new List<Contract>();

            //return obj;
        }
    }
}
