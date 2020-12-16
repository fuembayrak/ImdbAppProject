
using ImdbAppProject.EntityLayer.Entities.Concrete;
using System.Data.Entity;


namespace ImdbAppProject.DataAccessLayer.Context
{
    public class ProjectContext:DbContext // EntityFramework sayesinde DbContext nesnemizi tanimladik.
    {
        public ProjectContext() // Baglantiyi yolu Constructer methodunun icine yazildi.
        {
            Database.Connection.ConnectionString = @"Server=.;DataBase=ImdbAppProject;Integrated Security=True";
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AssignedMovietoDirector> AssignedMovietoDirectors { get; set; }
        public DbSet<AssignedMovietoGenre> AssignedMovietoGenres { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}
