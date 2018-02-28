using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Manager.ElectronicaDto
{
    public class LoginDto
    {
     [Display(Name ="Enter Email ID")]
     public string Email { get; set; }

     [Display(Name = "Enter Password")]
     public string Password { get; set; }

    }
}
