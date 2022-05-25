using Animales;

var Repository = new Repository();
Repository.LoadFile(@"C:\Users\Alondra\Documents\Primabera 2022\Animales" )
Console.WriteLine( "se cargo el archivo");




IFileWriter writer = new FileWriterXml();
writer.Write(Repository.GetAnimalWithPelo(" ").Take(10).ToList(), "animales en exel");

