﻿using Movies;

var repository = new Repository();
repository.LoadFile(@"C:\Users\joser\OneDrive\Documentos\TRSF\Spring 2022\movies.csv");
Console.WriteLine("Se cargo el archivo");
Console.WriteLine("Titulo    --    Genero  --- Idioma");
foreach (var movie in repository.GetAll().Take(10))
{
    Console.WriteLine($"{movie.Title}    --    {movie.Genre}  ---    {movie.OriginalLanguage}");
}
 

 IFileWriter writer = new FileWriterJson();
 writer.Write(repository.GetAll().Take(50).ToList(), "movies.json");

Console.Write("Archivo modificado");
 