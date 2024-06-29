using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Services;

public class AnimalsService(
    IAnimalsRepository animalsRepository
)
    : IAnimalsService
{
    public IEnumerable<Animal> GetAnimals(AnimalSortColumns? sortBy)
    {
        return animalsRepository.GetAnimals(sortBy ?? AnimalSortColumns.Name);
    }

    public void CreateAnimal(Animal animal)
    {
        animalsRepository.CreateAnimal(animal);
    }

    public void UpdateAnimal(Animal animal)
    {
        animalsRepository.UpdateAnimal(animal);
    }

    public void DeleteAnimal(int idAnimal)
    {
        animalsRepository.DeleteAnimal(idAnimal);
    }
}