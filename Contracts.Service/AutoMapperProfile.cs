using AutoMapper;
using Contracts.Data.Model;
using Contracts.Model;

namespace Contracts.Service
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ContractModel, Contract>();
        }
    }
}
