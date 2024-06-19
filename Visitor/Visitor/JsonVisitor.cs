
using Newtonsoft.Json;

namespace Visitor;

public class JsonVisitor : IVisitor
{
    public string Json;

    public void Visit(Car car)
    {
        Json +=  JsonConvert.SerializeObject(car);
    }

    public void Visit(Moto moto)
    {
        Json +=  JsonConvert.SerializeObject(moto);
    }

    public void Visit(Bicycle bicycle)
    {
        Json +=  JsonConvert.SerializeObject(bicycle);
    }

    
}