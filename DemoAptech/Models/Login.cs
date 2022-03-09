using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoAptech.Models
{
    public class Login
    {
        public string userName { get; set; }

        [DataType(DataType.Password)] public string password { get; set; }
    }

}