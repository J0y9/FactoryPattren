using FactoryPattren;
using FactoryPattren.Factory;

public class SquareCreator : ICreator
{
    public IShape CreateShape()
    {
        return new Square();
    }
}