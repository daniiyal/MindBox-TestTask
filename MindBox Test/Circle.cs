using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Test
{
    /// <summary>
    /// Класс треугольника реализует интерфейс фигуры
    /// </summary>
    public class Circle : IShape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
