using System;

namespace TrainChecklist.DTO
{
    public abstract class BaseDto<T>
    {
        public T Id {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime ModifiedAt {get; set;}
    }
}