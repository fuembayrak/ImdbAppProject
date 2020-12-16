using ImdbAppProject.EntityLayer.Entities.Abstract;
using ImdbAppProject.EntityLayer.Entities.Interfaces;
using ImdbAppProject.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImdbAppProject.EntityLayer.Entities.Concrete
{
    [Table("Movie")]
    public class Movie : BaseEntity<int>,IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        public string MovieName { get; set; }
        [Required]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }

        [Required]
        [MaxLength(200)]
        [MinLength(20)]
        public string MovieReview { get; set; }

        public List<AssignedMovietoGenre> AssignedMovietoGenres { get; set; } // AssignedMovietoGenre tablosu ile Movie tablosu ile bire cok iliskisi yapildi.
        public List<AssignedMovietoDirector> AssignedMovietoDirectors { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? PassiveDate { get; set; }
        public Status Status { get;set; }
    }
}
