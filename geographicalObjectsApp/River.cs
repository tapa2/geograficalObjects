using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geographicalObjectsApp
{
    public class River : GeographicalObject
    {

        public double FlowSpeed { get; set; } 
        public double Length { get; set; }    
        public River(double x, double y, string name, string description, double flowSpeed, double length) : base(x, y, name, description)
        {
            FlowSpeed = flowSpeed;
            Length = length;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"\nFlow Speed: {FlowSpeed} cm/s\nLength: {Length} km";
        }
    }
}
