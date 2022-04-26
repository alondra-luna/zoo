
public class persona
public class persona
{
    public string Nombre { get; set; }
    public int Age { get; set; }
    public persona(string nombre, int age)
    {
        Nombre = nombre;
        Age = age;
    }
    // Other properties, methods, events...
}

class Program
{
    static void Main()
    {
        persona persona1 = new persona("Mariana", 6);
        Console.WriteLine("persona1 Nombre = {0} Age = {1}", persona1.Nombre, persona1.Age);

        // Declare new persona, assign persona1 to it.
        persona persona2 = persona1;

        // Change the nombre of persona2, and persona1 also changes.
        persona2.Nombre = "Ulices";
        persona2.Age = 16;

        Console.WriteLine("persona2 Name = {0} Age = {1}", persona2.Nombre, persona2.Age);
        Console.WriteLine("persona1 Name = {0} Age = {1}", persona1.Nombrer, person1a.Age);
    }
}
/*
    Output:
    persona1 Nombre = Mariana Age = 6
    persona2 Nombre =  Ulices Age = 16
    persona1 Nombre = Ulices Age = 16
*/