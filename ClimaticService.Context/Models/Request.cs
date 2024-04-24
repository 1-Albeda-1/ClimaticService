using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaticService.Context.Models
{
    public class Request
    {
        [Key]
        public int IdRequest { get; set; }
        [Required]
        public DateTime DateAdd { get; set; } = DateTime.Now;
        public DateTime? DateClose { get; set; }
        public string Spares { get; set; } = string.Empty;
        public string EquipmentModel { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [ForeignKey("EquipmentType")]
        public int EquipmentTypeId { get; set; }
        public virtual EquipmentType EquipmentType { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual User Client { get; set; }
        public int? WorkerId { get; set; }
        [ForeignKey("WorkerId")]
        public virtual User Worker { get; set; }
        [ForeignKey("BrokenType")]
        public int? BrokenTypeId { get; set; }
        public virtual BrokenType BrokenType { get; set; }
        [ForeignKey("Status")]
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
