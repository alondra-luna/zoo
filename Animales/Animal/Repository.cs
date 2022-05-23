namespace Animal;
public class Repository
{
    public List<Animal> ListAnimal { get; set; }
    private bool LoadedFile {get; set;} = false;
    public void LoadFile(String filename)
    {
        try
        {
            ListAnimal = new List<Animal>();
            var listAnimalString = FileReader.ReadFile(filename);
            foreach (var item in listAnimalString.Skip(1).Take(20))
            {
                // Console.WriterLine(item);
                var parser = new Parser();
                var animal = parser.Parser(item);
                ListAnimal.Add(animal);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        LoadedFile = true;
    }
    public List<Animal> GetAll ()
    {
        if(LoadedFile == false)
        {
            throw new Exception("No se ha cargado el archivo");
        }
        return ListAnimal;
    }
    public List<Animal> GetAnimal (String Tiene_pelo)
    {
        Console.WriteLine("el animal puede tener pelo");
        if(LoadedFile == false)
        {
            throw new Exception("aun no carga el archivo");
        }
        return ListAnimal.Where(m => m.Name.Contains(Name)).ToList();
    }
}