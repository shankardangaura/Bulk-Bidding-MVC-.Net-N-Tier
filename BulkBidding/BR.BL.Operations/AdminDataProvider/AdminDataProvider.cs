using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkRiddleCommonDS;
using Microsoft.ApplicationBlocks.Data;

namespace BR.BL.Operations.AdminDataProvider
{
    public class AdminDataProvider:IAdminDataProvider
    {
        public BRWebResponse GetRevenueAndExpenses()
        {
            BRWebResponse response = new BRWebResponse();
            response.bPass = true;
            BRParameter oResult = new BRParameter();
            try
            {
                string _SQL = "";
                DataSet ds = BRSQLHelper.ExecuteDataset(BRConnectionString.GetConnectionString, CommandType.Text, _SQL);


            }
            catch (Exception)
            {

            }

            oResult.stringValue = "";
            response.ResultValue = oResult;
            return response;
        }
    }
}
