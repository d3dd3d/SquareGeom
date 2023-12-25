using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareGeom
{
    public class Triangle : Figure
    {
        double[] sides = new double[3];
        public Triangle(double sideA, double sideB, double sideC)
        {
            if ((sideA <= 0) || (sideB <= 0) || (sideC <= 0))
                throw new ArgumentException("AnyInvalid");

            double maxSide = Math.Max(Math.Max(sideA, sideB),sideC);
            double pow2SumOtherSides = Math.Pow(sideA, 2)+ Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - Math.Pow(maxSide, 2) ;
            
            if (Math.Pow(maxSide,2)>pow2SumOtherSides)
            {
                throw new ArgumentException("TriangleNotExist");
            }
            else{
                sides[0] = sideA;
                sides[1] = sideB;
                sides[2] = sideC;
            }
        }
        private Triangle() { }
        public override double getSquare()
        {
            double p = (sides[0] + sides[1] + sides[2]) /2;
            return Math.Sqrt(p*(p- sides[0]) *(p- sides[1]) *(p- sides[2]));
        }
        public static bool isRect(Triangle t)
        {
            double sum = 0;
            foreach (var side in t.sides)
            {
                sum += Math.Pow(side,2);
            }
            sum -= Math.Pow(t.sides.Max(),2);
            return sum== Math.Pow(t.sides.Max(), 2);
        } 
    }
}
