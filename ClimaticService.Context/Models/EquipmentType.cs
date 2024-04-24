using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaticService.Context.Models
{
    public class EquipmentType
    {
        [Key]
        public int IdEquipmentType { get; set; }
        [Required]
        public string EquipmentTypeTitle { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
