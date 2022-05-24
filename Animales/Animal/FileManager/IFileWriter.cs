namespace Animales;
public interface IFileWriter
{
    public void Write(List<Animal> animal, string path);
}