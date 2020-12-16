using ImdbAppProject.EntityLayer.Entities.Abstract;
using ImdbAppProject.EntityLayer.Entities.Interfaces;
using ImdbAppProject.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImdbAppProject.EntityLayer.Entities.Concrete
{
    [Table("Genre")]
    public class Genre : BaseEntity<int>, IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        public string GenreName { get; set; }

        public List<AssignedMovietoGenre> AssignedMovietoGenres { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? PassiveDate { get; set; }
        public Status Status { get; set; }
    }
}
