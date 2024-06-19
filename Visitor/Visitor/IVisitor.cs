namespace Visitor;

public interface IVisitor
{
    public void Visit(Car car);
    public void Visit(Moto moto);
    public void Visit(Bicycle bicycle);
}