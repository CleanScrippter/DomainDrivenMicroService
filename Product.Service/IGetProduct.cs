﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service
{
    public interface IGetProduct
    {
        void GetActiveProducts(string contractName);
    }
}
