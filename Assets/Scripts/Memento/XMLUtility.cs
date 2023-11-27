using System;
using System.IO;
using System.Xml.Serialization;

// 辅助类，使得XML适配器和JSON的接口类似
public class XMLUtility
{
    public static string ToXml<T>(T obj)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        StringWriter writer = new StringWriter();
        serializer.Serialize(writer, obj);
        return writer.ToString();
    }

    public static T FromXml<T>(string xml)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        StringReader reader = new StringReader(xml);
        return (T)serializer.Deserialize(reader);
    }
}