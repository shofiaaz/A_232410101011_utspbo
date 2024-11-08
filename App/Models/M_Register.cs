using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_232410101011_utspbo.App.Models
{
    internal class M_Register
    {
        [Key]
        public string nama { get; set; }
        [Required]
        public string alamat { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public int telepon { get; set; }
        [Required]
        public string username { get; set; }
        public string password { get; set; }
        [Required]
    }
}
