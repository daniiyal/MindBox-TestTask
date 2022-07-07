namespace MindBox_Test
{
    /// <summary>
    /// Для Облегчения добавления фигур был исполтьзован паттерн "Фабричный метод"
    /// Класс создатель фигур объявляет фабричный метод, который возвращает определенную фигуру
    /// </summary>
    public abstract class ShapeCreator
    {
        public abstract IShape CreateFigure(params double[] args);

    }
}