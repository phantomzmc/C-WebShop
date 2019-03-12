using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TesWin1
{
    interface InterfaceOrder
    {
        DataTable getOrder();
        int addOrder();
        int delOrder();
        int editOrder();
    }
}
