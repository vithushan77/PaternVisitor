namespace Visitor;

public class Car :IVisitable
{

    public Guid Id = Guid.NewGuid();
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Moto : IVisitable {
    
    public Guid Id = Guid.NewGuid();
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
    
}

public class Bicycle : IVisitable {
    public Guid Id = Guid.NewGuid();
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
    
}