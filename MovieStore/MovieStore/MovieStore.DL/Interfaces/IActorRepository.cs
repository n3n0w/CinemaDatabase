using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IActorRepository
    {
        IEnumerable<Actor> GetActorsByIds(IEnumerable<int> actorsIds);
        IEnumerable<Actor> GetActorsByIds(List<string> actors);
        Actor? GetById(int id);
    }
}
