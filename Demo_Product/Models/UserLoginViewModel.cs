using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage="Kullanıcı adını giriniz")]
        public string  UserName { get; set; }

        [Required(ErrorMessage = "Şifre giriniz")]
        public string Password { get; set; }
    }
}
