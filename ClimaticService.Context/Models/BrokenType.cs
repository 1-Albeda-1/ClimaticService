using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaticService.Context.Models
{
    public class BrokenType
    {
        [Key]
        public int IdBrokenType { get; set; }
        [Required]
        public string BrokenTypeTitle { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
