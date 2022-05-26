using Animales;

var Repository = new Repository();
Repository.LoadFile(@".\zoo.csv" );
Console.WriteLine( "se cargo el archivo");




IFileWriter writer = new FileWriterXml();
//writer.Write(Repository.GetAnimalWithPelo(true).Take(10).ToList(), "animales en exel.xml");
writer.Write(Repository.GetAnimalWithPelo(false).ToList(), "animales en exel.xml");

