using MindBox_Test;

class Client
{
    public void Main()
    { 
        ClientCode(new CircleCreator());


        ClientCode(new TriangleCreator());
    }

    // Клиентский код работает с экземпляром конкретного создателя, хотя и
    // через его базовый интерфейс. Пока клиент продолжает работать с
    // создателем через базовый интерфейс, вы можете передать ему любой
    // подкласс создателя.
    public void ClientCode(FigureCreator creator)
    {
        if(creator.GetType() == typeof(CircleCreator))
        {
            var circle = creator.CreateFigure(10);
            Console.WriteLine(circle.GetArea());
        }
        else if (creator.GetType() == typeof(TriangleCreator))
        {
            var triangle = creator.CreateFigure(4, 5, 3);
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(((Triangle)triangle).isStraight());
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        new Client().Main();
    }
}
