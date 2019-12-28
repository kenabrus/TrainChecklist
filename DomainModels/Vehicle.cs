using System;

namespace TrainChecklist.DomainModels
{
    public class Vehicle : BaseEntity<long>
    {
        public string Name {get; private set;}
        public Vehicle(){}

        private Vehicle(string name)
        {
            SetName(name);
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
        }

        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception($"Parameter Name can not be empty.");
            }

            if(Name == name)
            {
                return;
            }

            Name = name;
            SetModifiedAt(DateTime.UtcNow);
        }

        public void SetModifiedAt(DateTime modifiedAt)
            {
                ModifiedAt = modifiedAt;
            }

        public static Vehicle Create(string name)
        => new Vehicle(name);
    }
}