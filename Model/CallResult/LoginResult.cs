using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.CallResult
{
    public class LoginResult : WebResult
    {
        public LoginDto Data
        {
            get; set;
        }
    }
}
