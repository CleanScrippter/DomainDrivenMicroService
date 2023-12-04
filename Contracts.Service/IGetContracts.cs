using Contracts.Data.Model;
using Contracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Service
{
    public interface IGetContracts
    {
        Contract GetActiveContracts(int countryId);
    }
}
