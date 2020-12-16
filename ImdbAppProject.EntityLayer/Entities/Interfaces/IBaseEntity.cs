using ImdbAppProject.EntityLayer.Enums;
using System;


namespace ImdbAppProject.EntityLayer.Entities.Interfaces
{
    public interface IBaseEntity
    {
        // Assigned tablolarin sadece BaseEntity'den kalitim altiklari "Id" parametresinin gorunmesi acisindan IBaseEntity.cs acip asagidaki proportyleri istedigimiz taablolara implement ettik.
        DateTime? CreateDate { get; set; }  // "?" Bos gecilebilir.
        DateTime? ModifiedDate { get; set; }
        DateTime? PassiveDate { get; set; }

        Status Status { get; set; }
    }
}
