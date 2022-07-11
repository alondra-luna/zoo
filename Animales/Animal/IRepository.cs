namespace Animales
{
    public interface IRepository
    {
        List<Animal> GetAll();
        List<Animal> GetAnimalByName(string Name);

        long Create(Animal animal);
    }
}