using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IActorRepository
    {
        IEnumerable<Actor> GetActorsByIds(IEnumerable<int> actorsIds);
        Actor? GetById(int id);
    }
}
