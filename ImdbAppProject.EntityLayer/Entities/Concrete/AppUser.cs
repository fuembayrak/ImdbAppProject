using ImdbAppProject.EntityLayer.Entities.Abstract;
using ImdbAppProject.EntityLayer.Entities.Interfaces;
using ImdbAppProject.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImdbAppProject.EntityLayer.Entities.Concrete
{
    [Table("AppUser")] // Tablo ismi verildi.
    public class AppUser : BaseEntity<int>,IBaseEntity
    {
        [Key] // PrimaryKey verildi.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity eklendi.
        public override int Id { get; set; } // BaseEntity'de abstract olarak tanimadigimiz Id override edildi.


        [Required] // Bos gecilmemesini sagladik
        [MaxLength(15)] // Karakter uzunlugunu maksimum 15 karakter olarak verildi.
        [MinLength(3)] // Minimum karakter uzunlugu 3 olarak verildi.
        public string FirstName { get; set; }


        [Required]
        [MaxLength(15)]
        [MinLength(2)]
        public string LastName { get;set; }


        [Required]
        [MaxLength(10)]
        [MinLength(3)]
        public string UserName { get; set; }


        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Password { get; set; }

        public string FullName => FirstName + " " + LastName;
        public Role Role { get; set; } //Enum dosyasindan, Role classindan Role alindi.

        public List<AssignedMovietoDirector> AssignedMovietoDirectors { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? PassiveDate { get; set; }
        public Status Status { get; set; }
    }
}
