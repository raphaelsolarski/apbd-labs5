using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[Route("/api/animals")]
[ApiController]
public class AnimalsController(IAnimalsService animalsService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetPatientInfo([FromQuery] AnimalSortColumns? sortBy)
    {
        return Ok(animalsService.GetAnimals(sortBy));
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        animalsService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        animal.IdAnimal = id;
        animalsService.UpdateAnimal(animal);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        animalsService.DeleteAnimal(id);
        return NoContent();
    }
}