using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geographicalObjectsApp
{
    public class Mountain : GeographicalObject
    {
    public double HighestPoint { get; set; } 

    public Mountain(double x, double y, string name, string description, double highestPoint)
        : base(x, y, name, description)
    {
        HighestPoint = highestPoint;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $"\nHighest Point: {HighestPoint} m";
    }
}
}
