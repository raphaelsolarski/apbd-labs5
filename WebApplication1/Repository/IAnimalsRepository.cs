using WebApplication1.Models;

namespace WebApplication1.Repository;

public interface IAnimalsRepository
{
    IEnumerable<Animal> GetAnimals(AnimalSortColumns sortBy);
    void CreateAnimal(Animal animal);
    void UpdateAnimal(Animal animal);
    void DeleteAnimal(int idAnimal);
}