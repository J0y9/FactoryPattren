
using FactoryPattren.Factory;

ICreator circleCreator = new CircleCreator();
var circle = circleCreator.CreateShape();
circle.Draw();
circle.SayHi();