using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestServices.TestSQLHelper;
using TestServices.WebResponse;

namespace TestServices.CRUDServices
{
    public class CRUDService : ICRUDService
    {
        public TestWebResponse GetRevenueAndExpenses()
        {
            TestWebResponse response = new TestWebResponse();
            response.bPass = true;
            TestingParameter oResult = new TestingParameter();
            try
            {

                DataSet ds = TestSQLHelper.ExecuteDataset(new DBConnection.TestConnectionString().GetConnectionString(), CommandType.Text, _SQL);


            }
            catch (Exception)
            {

            }

            oResult.stringValue = "";
            response.ResultValue = oResult;
        }
    }
}
