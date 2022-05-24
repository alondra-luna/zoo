using System.Xml.Serialization;

namespace Animales;

public class FileWriterXml : IFileWriter
{
    public void Write(List<Animal> animal, string path)
    {
        var serializer =new XmlSerializer(typeof(List<Animal>));
        using (var writer = new StreamWriter(path))
        {
            serializer.Serialize(writer, animal);
        }
    }
}