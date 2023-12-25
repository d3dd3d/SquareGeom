using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareGeom
{
    public class Circle : Figure
    {
        double radius;
        public Circle(double radius) {
            if (radius <= 0)
                throw new ArgumentException("AnyInvalid");
            else
                this.radius = radius;
        }
        private Circle() { }
        public override double getSquare()
        {
            return Math.Pow(radius, 2)*Math.PI;
        }
        
    }
}
