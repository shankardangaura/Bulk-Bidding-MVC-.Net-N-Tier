using BulkRiddleCommonDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR.BL.Operations.AdminDataProvider
{
    public interface IAdminDataProvider
    {
        public BRWebResponse GetRevenueAndExpenses();
    }
}
