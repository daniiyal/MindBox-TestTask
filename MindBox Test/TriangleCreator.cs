using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Test
{
    public class TriangleCreator : FigureCreator
    {
        public override IFigure CreateFigure(params double[] args)
        {
            if (args.Length == 3 &&
                args[0] > 0 && args[1] > 0 && args[2] > 0 &&
                args[0] < args[1] + args[2] &&
                args[1] < args[0] + args[2] &&
                args[2] < args[0] + args[1])
                return new Triangle(args[0], args[1], args[2]);
            else
                throw new ArgumentException("Нельзя создать треугольник с такими параметрами");

        }
    }
}
