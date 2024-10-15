using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGeographicalObjectApp
{
    public class River : IGeographicalObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double FlowSpeed { get; set; }
        public double Length { get; set; }

        public River(double x, double y, string name, string description, double flowSpeed, double length)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            FlowSpeed = flowSpeed;
            Length = length;
        }

        public string GetInfo()
        {
            return $"Name: {Name}\nDescription: {Description}\nCoordinates: ({X}, {Y})\nFlow Speed: {FlowSpeed} cm/s\nLength: {Length} km";
        }
    }

}
