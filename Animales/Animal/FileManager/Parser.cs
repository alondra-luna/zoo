namespace Animales;
public class Parser
{
    public Animal Parse(string line)
    {
        var animal = new Animal();
        var values = line.Split(',');
        animal.Name = values[0];

        animal.Tiene_pelo = values[1] == "1" ? true : false;
        animal.Tiene_plumas = values[2] == "1" ? true : false;
 
        //wolf,1,0,0,1,0,0,1,1,1,1,0,0,4,1,0,1,1
       if(Int32.TryParse( values[17], out int classificacionAnimal))
       {
            animal.Clasificacion = (Clasificacion)classificacionAnimal;
       } 
        return animal;
    }
}    

   