using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_232410101011_utspbo.App.Models
{
    internal class M_Login
    {
        [Key]
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
    }
}
