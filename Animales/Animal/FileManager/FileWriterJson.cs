using Newtonsoft.Json;

namespace Animal;
public class FileWriterJson : IFileWriter 
{
    public void Writer(List<Animal> animal, string path)
    {
        var json = JsonConvert.SerializeObject(animal);
        File.WriteAllText(path, json);
    }
}