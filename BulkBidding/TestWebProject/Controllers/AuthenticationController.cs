using BulkRiddleCommonDS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TestWebProject.Models;
using Microsoft.AspNetCore.Http;
using BRDataModels;
using Microsoft.AspNetCore.Html;
using System.Reflection;

namespace TestWebProject.Controllers
{
    public class AuthenticationController : Controller
    {
        TestWebProject.ServiceAgent.AuthenticationServiceAgent.IAuthenticationServiceAgent _serviceAgent = new TestWebProject.ServiceAgent.AuthenticationServiceAgent.AuthenticationServiceAgent();
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("BulkBidingSession") != null || HttpContext.Session.GetString("UserRole")!=null)
            {
                HttpContext.Session.Remove("BulkBidingSession");
                HttpContext.Session.Remove("userId");
                HttpContext.Session.Remove("UserRole");
            }
            return RedirectToAction("Login");
        }
        [HttpPost,AllowAnonymous]
        public IActionResult Login(LoginViewModel _model)
        {
            var _return = _serviceAgent.CheckValidUser(_model);
            var _returnValue= int.Parse(_return.ResultValue.stringValue);
            if(_model!=null && _model.UserName!=null && _model.Password != null && _returnValue>0)
            {
                HttpContext.Session.SetString("BulkBidingSession", _model.UserName);
                HttpContext.Session.SetString("userId", _returnValue.ToString());
                if (_model.isCompany==1)
                {
                    HttpContext.Session.SetString("UserRole", "Company");
                    return RedirectToAction("CompanyPage");
                }
                else
                {
                    HttpContext.Session.SetString("UserRole", "Individual");
                }
                return RedirectToAction("IndividualPage");
            }
            else
            {
                ViewBag.Errormessage = "Username and password doesn't match";
            }
           
            return View();
        }

        public IActionResult SignUp()
        {
            return View(new SignUpViewModal());
        }

        public IActionResult SignUpIndividual()
        {
            var model = new SignUpViewModal();
            model.isCompany = false;
            return View(model);
        }

        public IActionResult SignUpCompany()
        {
            return View(new SignUpViewModal());
        }
        [HttpPost]
        public IActionResult SignUp(SignUpViewModal model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    BRWebResponse _response = _serviceAgent.InsertUpdateUser(model);
                    if (_response.ResultValue.stringValue == "1")
                    {
                        return RedirectToAction("Login");
                    }
                    return View("SignupIndividual", model);
                }
                catch (Exception e)
                {
                    return View("SignupIndividual", model);
                }
            }
            return View("SignupIndividual", model);
        }
        [HttpPost]
        public IActionResult CompanySignUp(SignUpViewModal model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.isCompany = true;
                    BRWebResponse _response = _serviceAgent.InsertUpdateUser(model);
                    if (_response.ResultValue.stringValue == "1")
                    {
                        return RedirectToAction("Login");
                    }
                    return View("SignupCompany", model);
                }
                catch (Exception e)
                {
                    return View("SignupCompany", model);
                }
            }
            return View("SignupCompany", model);
        }
        public IActionResult IndividualPage()
        {
            ViewBag.userId=HttpContext.Session.GetString("userId");
            try
            {
                if (HttpContext.Session.GetString("BulkBidingSession") != null && HttpContext.Session.GetString("UserRole").ToString() == "Individual")
                {
                    return View(new BRDataModels.Post());
                }
                else
                {
                    return RedirectToAction("Login", new LoginViewModel());
                }
            }
            catch (Exception)
            {

                return RedirectToAction("Login", new LoginViewModel());
            }
        }
        [HttpPost]
        //public IActionResult postCreate(Authentication model)
        //{
        //    BRWebResponse _response = _serviceAgent.InsertUpdatePost(model);
        //    try
        //    {
        //        return new HtmlString(_response.ResultValue.stringValue);
        //    }
        //    catch (Exception)
        //    {
        //        return new HtmlString("0");
        //    }

        //}

        public IActionResult CompanyPage()
        {
            try
            {
                if (HttpContext.Session.GetString("BulkBidingSession") != null && HttpContext.Session.GetString("UserRole").ToString() == "Company")
                {
                    return View(new Authentication());
                }
                else
                {
                    return RedirectToAction("Login", new LoginViewModel());
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Login", new LoginViewModel());

            }
           
        }

        public IActionResult UserList()
        {
            return View(GetUserList());
        }
        //public HtmlString Individual(SignUpViewModal model)
        //{
        //    BRWebResponse _response = _serviceAgent.InsertUpdateUser(model);
        //    try
        //    {
        //        return new HtmlString(_response.ResultValue.stringValue);
        //    }
        //    catch (Exception)
        //    {
        //        return new HtmlString("0");
        //    }
        //}
        public PartialViewResult Individual(int id = 0)
        {
            if (id > 0)
            {
                BRWebResponse _response = _serviceAgent.GetUserList();
                try
                {
                    XDocument _xDoc = XDocument.Parse(_response.ResultValue.stringValue);

                    var _data = (from x in _xDoc.Descendants("Table")
                                 select new SignUpViewModal
                                 {
                                     userId = x.Element("id") != null && !string.IsNullOrEmpty(x.Element("id").Value) ? int.Parse(x.Element("id").Value) : 0,
                                     phone = x.Element("phone") != null && !string.IsNullOrEmpty(x.Element("phone").Value) ? int.Parse(x.Element("id").Value) : 0,
                                     userName = x.Element("userName").Value ?? "",
                                     Password = x.Element("password").Value ?? "",
                                     Email = x.Element("email").Value ?? "",
                                     isActive = x.Element("isActive").Value == "True" ? true : false
                                 }).FirstOrDefault();
                    return PartialView(_data);

                }
                catch (Exception ex)
                {
                    return PartialView(new SignUpViewModal());
                }
            }
            return PartialView(new SignUpViewModal());
        }
        public IEnumerable<Authentication> GetUserList()
        {
            BRWebResponse _response = _serviceAgent.GetUserList();

            try
            {
                XDocument _xDoc = XDocument.Parse(_response.ResultValue.stringValue);

                var _data = (from x in _xDoc.Descendants("Table")
                             select new Authentication
                             {
                                 userId = int.Parse(x.Element("id").Value),
                                 userName = x.Element("userName").Value ?? "",
                                 Password = x.Element("password").Value ?? "",
                                 Email = x.Element("email").Value ?? "",
                                 isActive = x.Element("isActive").Value == "True" ? true : false
                             }).ToList();
                return _data;
            }
            catch (Exception ex)
            {
                return new List<Authentication>();
            }
        }

        #region Post

        public IActionResult GetPostDetail(int userId)
        {
            var _data = GetPostList(userId);
            return View("Post/_List",_data );
        }
        internal List<Post> GetPostList(int userId)
        {
            try
            {
                BRWebResponse _response = _serviceAgent.GetPostList(userId);
                var _xDoc =XDocument.Parse(_response.ResultValue.stringValue);
                var _data = (from x in _xDoc.Descendants("Table")
                             select new Post()
                             {
                                 Id = string.IsNullOrEmpty(x.Element("id").Value) ? 0 : int.Parse(x.Element("id").Value),
                                 PostTitle = x.Element("title").Value,
                                 // Other properties as needed
                                 Comments = (from y in _xDoc.Descendants("Table1")
                                             where y.Element("id").Value == x.Element("id").Value
                                             select new Comment()
                                             {
                                                 CommentBy = y.Element("commentedBy").Value,
                                                 PostComment = y.Element("comment").Value,
                                                 CommentOn = y.Element("commentedOn").Value
                                             }).ToList()
                             }).ToList();

                return _data;
            }
            catch (Exception)
            {

                return new List<Post>();
            }
            
        }
        #endregion
    }
}
