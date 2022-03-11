using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoAptech.Models
{
    public class UserValidate
    {
        public long Id { get; set; }
        [DisplayName("Họ và  tên")]
        [Required(ErrorMessage = "Bạn phải nhập tên")]
        
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ReenterPassword { get; set; }
        [Required]
        public int Age { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
 ErrorMessage = "Email	is not	valid.")]
        public string Email { get; set; }
    }
}