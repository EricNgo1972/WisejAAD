using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WisejAAD
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var root = Request.Url.ToString().Replace(Request.RawUrl, "");            
                        
            if (Request.IsAuthenticated)
                DoLogout(root);
            else
            {
                var usr = Context.User.Identity.Name;
                Response.Redirect(root);
            }


        }

        private void DoLogout(string pRedirect)
        {            
            HttpContext.Current.GetOwinContext().Authentication.SignOut(
                new AuthenticationProperties { RedirectUri = pRedirect },
                OpenIdConnectAuthenticationDefaults.AuthenticationType,
                CookieAuthenticationDefaults.AuthenticationType);
        }


    }
}