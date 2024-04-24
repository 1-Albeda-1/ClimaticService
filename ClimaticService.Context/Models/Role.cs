using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaticService.Context.Models
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }
        [Required]
        public string RoleTitle { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
