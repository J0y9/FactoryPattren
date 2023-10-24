namespace FactoryPattren;

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");

    }

    public void SayHi()
    {
        Console.WriteLine("Hi i'm circle");

    }
}