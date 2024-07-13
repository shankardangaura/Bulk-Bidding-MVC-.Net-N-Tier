using BR.BL.Operations.AdminDataProvider;
using BulkRiddleCommonDS;

namespace TestWebProject.ServiceAgent
{
    public class ServiceAgent:IServiceAgent
    {
        BR.BL.Operations.AdminDataProvider.IAdminDataProvider _request = new BR.BL.Operations.AdminDataProvider.AdminDataProvider();
        public BRWebResponse ShowData()
        {
            var _response =_request.GetRevenueAndExpenses();
            return _response;
        }
    }
}
