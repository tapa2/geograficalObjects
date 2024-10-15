using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geographicalObjectsApp
{
    public abstract class GeographicalObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public GeographicalObject(double x, double y, string name, string description)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
        }



        public virtual string GetInfo()
        {
            return $"Name: {Name}\nDescription: {Description}\nCoordinates: ({X}, {Y})";
        }
        public virtual string GetName()
        {
            return Name;
        }

        public virtual void RunMenu() 
        { 
            
        }

    }
}
