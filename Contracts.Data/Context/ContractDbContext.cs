using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Data.Context
{
    using Microsoft.EntityFrameworkCore;
    using Contracts.Data.Model;
    public class ContractDbContext : DbContext
    {
        public ContractDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<ContractModel> Contracts { get; set; }
    }
}
