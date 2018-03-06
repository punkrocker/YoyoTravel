using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelService.Models
{
    public class LoginViewModel: IUser<Guid>
    {
        [Required]
        [Display(Name = "用户名")]
        public string UserName
        {
            get; set;
        }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password
        {
            get; set;
        }

        public Guid Id
        {
            get
            {
                return new Guid();
            }
        }
    }
}