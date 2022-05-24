using Newtonsoft.Json;

namespace Animales;
public class FileWriterJson : IFileWriter 
{
    public void Write(List<Animal> animal, string path)
    {
        var json = JsonConvert.SerializeObject(animal);
        File.WriteAllText(path, json);
    }
}