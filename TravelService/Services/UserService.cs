using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace TravelService.Services
{
    public class UserService
    {
        public static ClaimsIdentity CheckIdentity(string userName, string pass)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(pass))
            {
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, userName));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, "0"));
                claims.Add(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "ASP.NET Identity"));
                int rid = 0;
                claims.Add(new Claim(ClaimTypes.Role, rid.ToString()));
                var identity = new ClaimsIdentity(claims, "MyClaimsLogin");
                return identity;
            }

            return null;
        }

    }
}