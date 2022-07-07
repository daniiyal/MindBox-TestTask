namespace MindBox_Test
{
    /// <summary>
    /// Создатель окружности
    /// </summary>
    public class CircleCreator : ShapeCreator
    {
        public override IShape CreateFigure(params double[] args)
        {
            if (args.Length == 1 && args[0] > 0)
                return new Circle(args[0]);
            else
                throw new ArgumentException("Нельзя создать окружность с такими параметрами");
        }
    }
}
