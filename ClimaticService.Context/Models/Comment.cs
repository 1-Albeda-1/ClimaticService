using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaticService.Context.Models
{
    public class Comment
    {
        [Key]
        public int IdComment { get; set; }
        [Required]
        public string CommentText { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Request")]
        public int RequestId { get; set; }
        public virtual Request Request { get; set; }
    }
}
