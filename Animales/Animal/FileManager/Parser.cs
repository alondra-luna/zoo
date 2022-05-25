namespace Animales;
public class Parser
{
    public Animal Parse(string line)
    {
        var animal = new Animal();
        var values = line.Split(',');
        animal.Name = values[0];
        if(Boolean.TryParse(values[1], out var TienePelo))
            animal.Tiene_pelo = TienePelo;

        if(Enum.TryParse<Clasificacion>(line, out var clasificacionValue)) 
            animal.Clasificacion = clasificacionValue;

        
        animal.Name = values[3];



        return animal;


    }


}    

   