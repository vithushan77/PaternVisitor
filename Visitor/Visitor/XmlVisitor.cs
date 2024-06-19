using System.Xml.Serialization;

namespace Visitor;

public class XmlVisitor :IVisitor
{
    public string xml;
    public void Visit(Car car)
    {
        TextWriter writer = new StringWriter();

        XmlSerializer serializer = new XmlSerializer(typeof(Car));
        serializer.Serialize(writer, car);
        xml += writer.ToString();
        writer.Close();

    }

    public void Visit(Moto moto)
    {
        TextWriter writer = new StringWriter();

        XmlSerializer serializer = new XmlSerializer(typeof(Moto));
        serializer.Serialize(writer, moto);
        xml += writer.ToString();
        writer.Close();    }

    public void Visit(Bicycle bicycle)
    {
        TextWriter writer = new StringWriter();

        XmlSerializer serializer = new XmlSerializer(typeof(Bicycle));
        serializer.Serialize(writer, bicycle);
        xml += writer.ToString();
        writer.Close();    
    }
    
}