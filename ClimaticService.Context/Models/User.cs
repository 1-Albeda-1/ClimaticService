using ClimaticService.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaticService.Context
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        [ForeignKey("ClientId")]
        public virtual ICollection<Request> RequestClent { get; set; }
        [ForeignKey("WorkerId")]
        public virtual ICollection<Request> RequestWorker { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
