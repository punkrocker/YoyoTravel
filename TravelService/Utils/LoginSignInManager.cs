using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelService.Models;

namespace TravelService.Utils
{
    public class LoginSignInManager : SignInManager<LoginViewModel, Guid>
    {
        public LoginSignInManager(UserManager<LoginViewModel, Guid> userManager, IAuthenticationManager authenticationManager) : base(userManager, authenticationManager)
        {
        }
    }
}