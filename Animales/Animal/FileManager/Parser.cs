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
        animal.Pone_huevos = values[3] == "1" ? true : false;
        animal.Da_leche= values[4] == "1" ? true : false;
        animal.Puede_volar = values[5] == "1" ? true : false;
        animal.Puede_nadar = values[6] == "1" ? true : false;
        animal.Es_depredador = values[7] == "1" ? true : false;
        animal.Tiene_dientes = values[8] == "1" ? true : false;
        animal.Tiene_espinazo = values[9] == "1" ? true : false;
        animal.Respira = values[10] == "1" ? true : false;
        animal.Es_venenoso = values[11] == "1" ? true : false;
        animal.Tiene_alas = values[12] == "1" ? true : false;
        animal.Tiene_cola = values[14] == "1" ? true : false;
        animal.Es_domestico = values[15] == "1" ? true : false;

         if(Int64.TryParse(values[13], out long resultado))
        {
            animal.Cuantas_patas = resultado;
        }
        
        


        if(Int32.TryParse( values[17], out int classsificacionAnimal))
        {
            animal.Clasificacion = (Clasificacion)classsificacionAnimal;
        }
    
        return animal;
    }
}    
