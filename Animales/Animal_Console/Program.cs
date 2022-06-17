using Animales;

var Repository = new Repository();
Repository.LoadFile(@".\C:\Users\Alondra\Documents\Primabera 2022\Animales" );
Console.WriteLine( "se cargo el archivo");




IFileWriter writer = new FileWriterJson();
writer.Write(Repository.GetAnimalWithPelo(false).ToList(), "animales.json");

