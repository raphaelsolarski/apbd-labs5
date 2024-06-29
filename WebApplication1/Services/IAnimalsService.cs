using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Services;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals(AnimalSortColumns? sortBy);
    void CreateAnimal(Animal animal);
    void UpdateAnimal(Animal animal);
    void DeleteAnimal(int idAnimal);
}