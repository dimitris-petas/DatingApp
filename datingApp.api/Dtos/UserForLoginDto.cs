using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace datingApp.api.Dtos
{
    public class UserForLoginDto
    {
        public string Password { get; set; }
        public string Username { get; set; }
    }

}
