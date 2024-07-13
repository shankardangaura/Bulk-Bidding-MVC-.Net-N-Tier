using BulkRiddleCommonDS;
using TestWebProject.Models;

namespace TestWebProject.ServiceAgent.AuthenticationServiceAgent
{
    public interface IAuthenticationServiceAgent
    {
        BRWebResponse GetUserList();
        BRWebResponse CheckValidUser(BRDataModels.LoginViewModel model);
        BRWebResponse InsertUpdateUser(BRDataModels.SignUpViewModal model);
        BRWebResponse InsertUpdatePost(BRDataModels.Authentication model);
        BRWebResponse GetPostList(int userId);
    }
}
