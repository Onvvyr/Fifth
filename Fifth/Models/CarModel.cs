using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace fourth
{
    [Table("Cars")]
    public class CarModel
    {
        [Key]
        public int CarId { get; set; }
        [Column("Marka")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Marka musi mieć więcej niż 4 znaki, ale mniej niż 10")]
        public string Brand { get; set; }
        public string Model { get; set; }
        [Display(Name = "Kraj")]
        public Choose Country{ get; set; }
        public virtual ICollection<CommentModel> Comments { get; set; }
    }
    public enum Choose
    {
        Polska,
        Chiny,
        Rosja,
        Japonia
    }
}