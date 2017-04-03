using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithWebsite.Models.RoleViewModels
{
    public class IdentityRoleViewModel
    {
        [Key]
        [Display(Name = "ID")]
        public string RoleId { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string RoleName { get; set; }

        [ReadOnly(true)]
        [Display(Name = "Role Name")]
        public string NormalizedName { get; set; }

    }
}