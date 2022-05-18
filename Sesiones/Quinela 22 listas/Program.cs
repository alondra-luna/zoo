


List<String> Jugetes = new List<String>()
{
    "patin" , "paleta", "trares", "guantes", "libro", "carro"
};

List<String> Participantes = new List<String>()
{
    "Dulce", "Alondra", "Andrea", "Gonzalo", "Eunice", "Eduardo"
};

var resultado =  GenerarQuiniela (Jugetes, Participantes);

foreach (var item in resultado)
{
    Console.WriteLine(item);
}

List<String> GenerarQuiniela (List<String> Jugetes, List<String>Participantes)
{
    List<String> JugetesParticipantes = new List<string>();

	var sortedEquipos = Jugetes.OrderBy(_ => Guid.NewGuid());
    List<string> sortedParticipantes = Participantes.OrderBy(_ => Guid.NewGuid()).ToList();

    foreach (var item in sortedEquipos)
    {
        JugetesParticipantes.Add(item + " - " + sortedParticipantes.First());
        sortedParticipantes.RemoveAt(0);
    }
    return JugetesParticipantes;
}