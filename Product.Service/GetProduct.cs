using Contracts.Data;
using AutoMapper;
using Contracts.Data.Model;
using Contracts.Model;
namespace Product.Service
{

    public class GetProduct : IGetProduct
    {
        private IContractRepository _companyContext;
        private readonly IMapper _mapper;
        public GetProduct(IContractRepository companyContext, IMapper mapper)
        {
            _companyContext = companyContext;
            _mapper = mapper;
        }

        public void GetActiveProducts(string contractName)
        {
            ProductModel contractList = new ProductModel();
            IEnumerable<Products> obj = new List<Products>();

            //contractList = _companyContext.Get(1);

            //var employeeViewModel = _mapper.Map<Contract>(contractList);
            //return employeeViewModel;

            //List<Contract> obj = new List<Contract>();

            //return obj;
        }

    }
}
