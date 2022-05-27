namespace Animales;
public class FileReader
{

    public static List<string> ReadFile (String path)
    {
        try
        {
        return File.ReadAllLines(path).ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}