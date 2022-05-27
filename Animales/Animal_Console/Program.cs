using Animales;

var Repository = new Repository();
Repository.LoadFile(@".\zoo.csv" );
Console.WriteLine( "se cargo el archivo");




IFileWriter writer = new FileWriterXml();
writer.Write(Repository.GetAnimalWithPelo(false).ToList(), "animales en exel");

