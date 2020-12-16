using ImdbAppProject.EntityLayer.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImdbAppProject.EntityLayer.Entities.Concrete
{
    [Table("AssignedMovietoDirector")]
    public class AssignedMovietoDirector : BaseEntity<int>
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        //----movie
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public  virtual Movie Movie { get; set; }

        //-----appuser
        [ForeignKey("AppUser")]
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }


    }
}
