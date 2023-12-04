using Contracts.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Data
{
    public interface IContractRepository
    {
        ContractModel Get(int id);
    }
}
