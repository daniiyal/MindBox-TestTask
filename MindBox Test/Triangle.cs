using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Test
{
    public class Triangle : IFigure
    {
        double sideA, sideB, sideC;
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double GetArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p-sideA) * (p - sideB) * (p - sideC));
        }

        public bool isStraight()
        {
            var sides = new List<double>() { sideA, sideB, sideC };
            sides.Sort();
            return sides[2] == Math.Sqrt(sides[0] * sides[0] + sides[1] * sides[1]);
        }
    }
}
