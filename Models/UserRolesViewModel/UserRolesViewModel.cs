using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZenithWebsite.Models.RoleViewModels;

namespace ZenithWebsite.Models.UserRolesViewModel
{
    public class UserRolesViewModel
    {
        [Display(Name = "Username")]
        public string Username { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Roles")]
        public ICollection<String> Roles { get; set; }
    }
}