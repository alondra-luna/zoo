using Microsoft.AspNetCore.Mvc;
using Animales;

namespace AnimalWebApi.Controllers;




[ApiController]
[Route("api/[controller]")]
public class AnimalController : ControllerBase
{
    private readonly ILogger<AnimalController> _logger;
    private readonly Repository _repository;
    public AnimalController(ILogger<AnimalController> logger)
    {
        _logger = logger;
        _repository = new Repository();
        _repository.LoadFile(@"C:\C:\Users\Alondra\Documents\Primabera 2022\Animales");
    }
      
    [HttpGet]
    [Route("GetAnimal")]
    public IEnumerable<Animal> GetAnimal()
    {
        return _repository.GetAll();
    }

    [HttpGet]
    public IEnumerable<Animal> GetAnimalWithPelo(bool Tiene_pelo)
    {
       
        return _repository.GetAnimalWithPelo(Tiene_pelo);
    }

}