using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webapiloginapp1.Models;

namespace Webapiloginapp1.Controllers
{
    public class LoginController : ApiController
    {
        private codeitEntities db = new codeitEntities();

        [HttpPost]
        public string LoginUser(UserRegistration obj)
        {

            
            var objuser = db.UserRegistrations.FirstOrDefault(p => p.UserName == obj.UserName && p.Password == obj.Password);
            //  var product = products.FirstOrDefault((p) => p.Id == id);
            if (objuser == null)
            {
                return "Login Failed";
            }
            return "Login Suceess";

        }
        
    }
}
