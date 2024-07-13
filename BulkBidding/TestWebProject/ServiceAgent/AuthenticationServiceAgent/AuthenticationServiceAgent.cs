using BR.BL.Operations.AuthenticationDataProvider;
using BulkRiddleCommonDS;
using TestWebProject.Models;

namespace TestWebProject.ServiceAgent.AuthenticationServiceAgent
{
    public class AuthenticationServiceAgent : IAuthenticationServiceAgent

    {
        IAuthenticationDataProvider _request =new BR.BL.Operations.AuthenticationDataProvider.AuthenticationDataProvider();
        public BRWebResponse GetUserList()
        {
            var _response = _request.GetUserList();
            return _response;
        }
        public BRWebResponse CheckValidUser(BRDataModels.LoginViewModel model)
        {
            var _response = _request.CheckValidUser(model.UserName,model.Password,model.isCompany);
            return _response;
        }

        public BRWebResponse GetPostList(int userId)
        {
            var _response = _request.GetPostList(userId);
            return _response;
        }
        public BRWebResponse InsertUpdateUser(BRDataModels.SignUpViewModal model)
        {
            var _response = _request.InsertUpdateUser(model);
            return _response;
        }
        public BRWebResponse InsertUpdatePost (BRDataModels.Authentication model)
        {
            var _response = _request.InsertUpdatePost(model);
            return _response;
        }

    }
}