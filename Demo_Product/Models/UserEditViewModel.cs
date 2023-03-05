using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "İsim değeri giriniz!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim değeri giriniz!")]
        public string SurName { get; set; }  

        [Required(ErrorMessage = "Mail giriniz!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre giriniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifreyi tekrar giriniz!")]
        [Compare("Password", ErrorMessage = "Şifrenin eşleştiğinde emin olun")]
        public string ConfirmPassword { get; set; }
    }
}
