using BRDataModels;
using BulkRiddleCommonDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR.BL.Operations.AuthenticationDataProvider
{
    public interface IAuthenticationDataProvider
    {
        public BRWebResponse CheckValidUser(string userName,string password, int IsCompany);
        public BRWebResponse InsertUpdateUser(SignUpViewModal model);
        public BRWebResponse GetUserList();
        public BRWebResponse GetPostList(int userId);
        public BRWebResponse InsertUpdatePost(BRDataModels.Authentication model);
    }
}
