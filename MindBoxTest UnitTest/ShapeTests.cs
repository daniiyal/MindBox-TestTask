namespace MindBoxTest_UnitTest
{
    /// <summary>
    /// Юнит-тесты xUnit для проверки правильности вычисления площадей и определения прямоугольности треугольника
    /// </summary>
    public class AreaCalcTests
    {
        public double GetArea(ShapeCreator creator, params double[] args)
        {
            if (creator.GetType() == typeof(CircleCreator))
            {
                var circle = creator.CreateFigure(args[0]);
                return circle.GetArea();
            }
            else if (creator.GetType() == typeof(TriangleCreator))
            {
                var triangle = creator.CreateFigure(args[0], args[1], args[2]);
                return triangle.GetArea();
            }
            else
            {
                throw new ArgumentException("Неизвестная фигура");
            }
        }

        
        [Fact]
        public void Calc_Circle_Area()
        {
            var area = GetArea(new CircleCreator(), 2);

            Assert.Equal(Math.PI * 2 * 2, area);
        }

        [Fact]
        public void Calc_Triangle_Area()
        {
            var area = GetArea(new TriangleCreator(), 3, 4, 5);

            Assert.Equal(6, area);
        }

        [Fact]
        public void Check_If_Triangle_Is_Straight()
        {
            var triangleCreator = new TriangleCreator();
            var triangle = triangleCreator.CreateFigure(3, 4, 5);

            bool isStraight = ((Triangle)triangle).isStraight();

            Assert.True(isStraight);
        }
    }


}