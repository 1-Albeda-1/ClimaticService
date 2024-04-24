using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaticService.Context.Models
{
    public class Status
    {
        [Key]
        public int IdStatus { get; set; }
        [Required]
        public string StatusTitle { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
