﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TesWin1
{
    interface InterfaceProduct
    {
        DataTable selectProduct();
        DataTable getProduct();
        int addProduct();
        DataTable getType();
    }
}
