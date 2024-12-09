using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories
{
    public class ActorStaticRepository : IActorRepository
    {
        public Actor? GetById(int id)
        {
            return StaticDB.InMemoryDb.Actors.
                FirstOrDefault(x => x.Id == id);
        }
    }
}
