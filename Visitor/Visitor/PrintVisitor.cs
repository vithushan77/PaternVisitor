namespace Visitor;

public class PrintVisitor : IVisitor {
    public void Visit(Car car)
    {
        Console.WriteLine("car");
    }

    public void Visit(Moto moto)
    {
        Console.WriteLine("moto");
    }

    public void Visit(Bicycle bicycle)
    {
        Console.WriteLine("bicycle");
    }
    
    
    
}