using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainChecklist.DomainModels
{
    public abstract class BaseEntity<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id {get; private set;}
        public DateTime CreatedAt {get; private set;}
        public DateTime ModifiedAt {get; private set;}

    }
}