namespace Animal;
public class Parser
{
    public Animal Parse(string line)
    {
        var animal = new Animal();
        var values = line.Split(',');
        animal.Name = string.Parse(values[0]);
        animal.Tiene_pelo = values[1];

        animal.Clasificacion = ParseClasificacion(values[2]);
        animal.Animal_Name = ParseAnimal_Name(values[3]);

        return animal;
    

    }
    public Clasificacion ParseClasificacion(string line)
    {
        Clasificacion returnValue = new Clasificacion();
        var values = line.Split(',');
        foreach (var item in values)
        {
            if(item.Any(Char.IsWhiteSpace))
            {
                if(item == "Mamifero")
                    returnValue = returnValue | Clasificacion.Mamiferos;

            }
            else 
            {
                if (Enum.TryParse<Clasificacion>(item, out var clasificacionValue))
                    returnValue = returnValue | clasificacionValue;
            }
        }
        return returnValue;

    }
    public Animal_Name ParseAnimal_Name(string item)
    {
        if (Enum.TryParse<Animal_Name>(item, out var Animal_Name))
             return Animal_Name;
        else
             return Animal_Name.none;     
    }
}