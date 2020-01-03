using System;
namespace TrainChecklist.DomainModels
{
    public class Element
    {
        public long Id {get; private set;}
        public string Name {get; private set;}

        private Element(){}

        public Element(string name)
        {
            SetName(name);
        }

        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception($"Name can not be empty.");
            }
            if(Name == name)
            {
                return;
            }
            Name = name;
        }

        public static Element Create(string name)
            => new Element(name);
    }
}