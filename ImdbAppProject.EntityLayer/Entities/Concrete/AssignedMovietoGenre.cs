using ImdbAppProject.EntityLayer.Entities.Abstract;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ImdbAppProject.EntityLayer.Entities.Concrete
{
    [Table("AssignedMovietoGenre")]
    public class AssignedMovietoGenre : BaseEntity<int>
    {
        
        //Bir filmin birden fazla turu, bir turun de birden fazla filmi olabilecegi icin coka cok iliskisi icin AssignedMovietoGenre tablosuna ihtiyacimiz vardir.
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [ForeignKey("Movie")]
        public  int MovieId { get; set; }  // Movie Keyin Primary Keyi burada Foreign key olarak verildi.
        public virtual Movie Movie { get; set; }

        [ForeignKey("Genre")]          //Genre Keyin Primary Keyi burada Foreign key olarak verildi.
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
