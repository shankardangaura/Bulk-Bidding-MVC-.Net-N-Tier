using BRDataModels;
using BulkRiddleCommonDS;
using Microsoft.ApplicationBlocks.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BR.BL.Operations.AuthenticationDataProvider
{
    public class AuthenticationDataProvider: IAuthenticationDataProvider
    {

        public BRWebResponse InsertUpdateUser()
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
        public BRWebResponse CheckValidUser(string userName, string password, int IsCompany)
        {
            BRWebResponse response = new BRWebResponse();
            response.bPass = true;
            BRParameter oResult = new BRParameter();
            try
            {
                string _SQL = $"select * from Authentication where email='{userName}'and password='{ password}'and isCompany={IsCompany}";
                object ds = BRSQLHelper.ExecuteScalar(BRConnectionString.GetConnectionString, CommandType.Text, _SQL);
                if(ds!=null)
                {
                    oResult.stringValue = ds.ToString();
                    response.ResultValue = oResult;
                    return response;
                }
                oResult.stringValue = "0";
                response.ResultValue = oResult;
                return response;
            }
            catch (Exception)
            {
                oResult.stringValue = "0";
                response.ResultValue = oResult;
                return response;
            }

           
        }
        public BRWebResponse GetUserList()
        {
            BRWebResponse response = new BRWebResponse();
            response.bPass = true;
            try
            {
                string _SQL = @"SELECT [id]
                                        ,[userName]
                                        ,[email]                             
                                        ,[password]                           
                                        ,[isActive]                     
                                        FROM [dbo].[Authentication]";
                DataSet ds = BRSQLHelper.ExecuteDataset(BRConnectionString.GetConnectionString, CommandType.Text, _SQL);
                if (ds != null)
                {
                    BRParameter oResult = new BRParameter();
                    oResult.stringValue = ds.GetXml();
                    response.ResultValue = oResult;
                }
                else
                {
                    response.ErrorMessage = "GetUserList - Sql Error, DataSet returned NULL value !";
                }

            }
            catch (Exception ex)
            {
                response.ErrorMessage = "GetUserList - Exception Error: " + ex.Message;
            }

            //oResult.stringValue = "";
            //response.ResultValue = oResult;
            return response;
        }
        public BRWebResponse InsertUpdateUser(SignUpViewModal model)
        {
            BRWebResponse response = new BRWebResponse();
            response.bPass = true;
            SqlParameter[] _param = new SqlParameter[11];
            _param[0] = new SqlParameter("@userId", model.userId);
            _param[1] = new SqlParameter("@userName", model.userName);
            _param[2] = new SqlParameter("@Email", model.Email);
            _param[3] = new SqlParameter("@Password", model.Password);
            _param[4] = new SqlParameter("@phone", model.phone);
            _param[5] = new SqlParameter("@address", model.address??"");
            _param[6] = new SqlParameter("@telePhone", model.telePhone);
            _param[7] = new SqlParameter("@webSite", model.webSite??"");
            _param[8] = new SqlParameter("@panNo", model.panNo);
            _param[9] = new SqlParameter("@isCompany", model.isCompany ? 1 : 0);
            _param[10] = new SqlParameter("@isActive", model.isActive ? 1 : 0);
            try
            {
                string _SQL = @"IF @userId = 0
		                                    BEGIN
			                                    INSERT INTO dbo.Authentication(userName, email,password,phone, address, telephone, webSite, panNo, isCompany, isActive)
			                                    VALUES (@userName, @Email,@Password, @phone, @address, @telePhone, @webSite, @panNo, @isCompany, @isActive);
		                                    END
		                                    ELSE
		                                    BEGIN
			                                    UPDATE dbo.Authentication
			                                    SET userName = @userName, 
				                                    email= @Email,
				                                    password = @Password,
				                                    phone =@phone,
                                                    address = @address,
                                                    telePhone = @telePhone,
                                                    webSite = @webSite,
                                                    panNo = @panNo,
                                                    isCompany = @isCompany,
                                                    isActive = @isActive
			                                    WHERE id = @userId;
		                                    END";
                DataSet ds = BRSQLHelper.ExecuteDataset(BRConnectionString.GetConnectionString, CommandType.Text, _SQL, _param);
                if (ds != null)
                {
                    BRParameter oResult = new BRParameter();
                    oResult.stringValue = "1";
                    response.ResultValue = oResult;
                }
                else
                {
                    response.ErrorMessage = "InsertUpdateUser - Sql Error, DataSet returned NULL value !";
                }

            }
            catch (Exception ex)
            {
                response.ErrorMessage = "InsertUpdateUser - Exception Error: " + ex.Message;
            }

            //oResult.stringValue = "";
            //response.ResultValue = oResult;
            return response;
        }
        public BRWebResponse InsertUpdatePost(BRDataModels.Authentication model)
        {
            BRWebResponse response = new BRWebResponse();
            response.bPass = true;
            SqlParameter[] _param = new SqlParameter[11];
            _param[0] = new SqlParameter("@userId", model.userId);
            _param[1] = new SqlParameter("@userName", model.userName);
            _param[2] = new SqlParameter("@Email", model.Email);
            _param[3] = new SqlParameter("@Password", model.Password);
            _param[4] = new SqlParameter("@phone", model.phone);
            _param[5] = new SqlParameter("@address", model.address??"");
            _param[6] = new SqlParameter("@telePhone", model.telePhone);
            _param[7] = new SqlParameter("@webSite", model.webSite??"");
            _param[8] = new SqlParameter("@panNo", model.panNo);
            _param[9] = new SqlParameter("@isCompany", model.isCompany ? 1 : 0);
            _param[10] = new SqlParameter("@isActive", model.isActive ? 1 : 0);
            try
            {
                string _SQL = @"IF @userId = 0
		                                    BEGIN
			                                    INSERT INTO dbo.Authentication(userName, email,password,phone, address, telephone, webSite, panNo, isCompany, isActive)
			                                    VALUES (@userName, @Email,@Password, @phone, @address, @telePhone, @webSite, @panNo, @isCompany, @isActive);
		                                    END
		                                    ELSE
		                                    BEGIN
			                                    UPDATE dbo.Authentication
			                                    SET userName = @userName, 
				                                    email= @Email,
				                                    password = @Password,
				                                    phone =@phone,
                                                    address = @address,
                                                    telePhone = @telePhone,
                                                    webSite = @webSite,
                                                    panNo = @panNo,
                                                    isCompany = @isCompany,
                                                    isActive = @isActive
			                                    WHERE id = @userId;
		                                    END";
                DataSet ds = BRSQLHelper.ExecuteDataset(BRConnectionString.GetConnectionString, CommandType.Text, _SQL, _param);
                if (ds != null)
                {
                    BRParameter oResult = new BRParameter();
                    oResult.stringValue = "1";
                    response.ResultValue = oResult;
                }
                else
                {
                    response.ErrorMessage = "InsertUpdateUser - Sql Error, DataSet returned NULL value !";
                }

            }
            catch (Exception ex)
            {
                response.ErrorMessage = "InsertUpdateUser - Exception Error: " + ex.Message;
            }

            //oResult.stringValue = "";
            //response.ResultValue = oResult;
            return response;
        }

        public BRWebResponse GetPostList(int userId)
        {
            BRWebResponse response = new BRWebResponse();
            response.bPass = true;
            try
            {
                string _SQL;
                if (userId > 0) {
                     _SQL = @$"SELECT * INTO #TEMP FROM dbo.Post WHERE  postBy = {userId}
                                SELECT *FROM #TEMP
                                SELECT *FROM dbo.Comment AS C 
                                INNER JOIN #TEMP AS Temp ON C.postId =Temp.id
                                INNER JOIN Authentication As A ON A.id = Temp.postBy
                                WHERE Temp.postBy = {userId}
                                DROP TABLE #TEMP";
                }
                else
                {
                     _SQL = @$"SELECT * INTO #TEMP FROM dbo.Post WHERE (1=1) 
                                SELECT *FROM #TEMP
                                SELECT *FROM dbo.Comment AS C 
                                INNER JOIN #TEMP AS Temp ON C.postId =Temp.id
                                INNER JOIN Authentication As A ON A.id = Temp.postBy
                                DROP TABLE #TEMP";
                }
                
                DataSet ds = BRSQLHelper.ExecuteDataset(BRConnectionString.GetConnectionString, CommandType.Text, _SQL);
                if (ds != null)
                {
                    BRParameter oResult = new BRParameter();
                    oResult.stringValue = ds.GetXml();
                    response.ResultValue = oResult;
                }
                else
                {
                    response.ErrorMessage = "GetUserList - Sql Error, DataSet returned NULL value !";
                }

            }
            catch (Exception ex)
            {
                response.ErrorMessage = "GetUserList - Exception Error: " + ex.Message;
            }
            return response;
        }
        public BRWebResponse GetCommentList(int userId)
        {
            BRWebResponse response = new BRWebResponse();
            response.bPass = true;
            try
            {
                string _SQL = @"SELECT [id]
                                        ,[comment]
                                        ,[commentedBy]                             
                                        ,[biddingPrice]                           
                                        ,[commentedOn]                    
                                        FROM [dbo].[Comment]";
                DataSet ds = BRSQLHelper.ExecuteDataset(BRConnectionString.GetConnectionString, CommandType.Text, _SQL);
                if (ds != null)
                {
                    BRParameter oResult = new BRParameter();
                    oResult.stringValue = ds.GetXml();
                    response.ResultValue = oResult;
                }
                else
                {
                    response.ErrorMessage = "GetUserList - Sql Error, DataSet returned NULL value !";
                }

            }
            catch (Exception ex)
            {
                response.ErrorMessage = "GetUserList - Exception Error: " + ex.Message;
            }
            return response;
        }
    }
}
