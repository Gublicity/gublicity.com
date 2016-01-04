using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gublicity.ViewModels
{
    public class AdministratorViewModel
    {

        public int Id { get; set; }

        [Required]
        [StringLength(20 , MinimumLength =5)]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }
    }
}
