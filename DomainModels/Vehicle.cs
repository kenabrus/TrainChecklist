using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainChecklist.DomainModels
{
    public class Vehicle : BaseEntity<long>
    {
        public string Name {get; private set;}

        //These are the DDD aggregate propties: Elenents
        private ISet<Element> _elements = new HashSet<Element>();
        public IEnumerable<Element> Elements
        {
            get { return _elements; }
            set { _elements = new HashSet<Element>(value); }
        }

        //private, parameterless constructor used by EF Core
        public Vehicle()
        {
        }

        public Vehicle(string name)
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

        public void AddElement(string name)
        {
            var element = Elements.SingleOrDefault(x => x.Name == name);
            if(element != null)
            {
                throw new Exception($"Element with name: '{name}' already exists for Vehicle: {Name}.");
            }
            _elements.Add(Element.Create(name));
            // UpdatedAt = DateTime.UtcNow;
        }

        public void DeleteElement(string name)
        {
            var element = Elements.SingleOrDefault(x => x.Name == name);
            if(element == null)
            {
                throw new Exception($"Element named: '{name}' for vehicle: '{Name}' was not found.");
            }
            _elements.Remove(element);
            // UpdatedAt = DateTime.UtcNow;            
        }

        public void DeleteAllElements()
        {
            foreach(Element e in Elements)
            {
                _elements.Remove(e);
                Console.WriteLine($"Deleted element {e.Name}.");
            }                   
        }

        public static Vehicle Create(string name)
        => new Vehicle(name);
    }
}