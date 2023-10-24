using FactoryPattren;
using FactoryPattren.Factory;

public class CircleCreator : ICreator
{
    public IShape CreateShape()
    {
        return new Circle();
    }
}