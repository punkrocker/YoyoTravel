using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class LoginDto
    {
        public int UserID
        {
            get; set;
        }
        public string UserName
        {
            get; set;
        }
        public List<String> Functions
        {
            get; set;
        }
    }
}
