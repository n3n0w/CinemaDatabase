using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories
{
    public class ActorStaticRepository : IActorRepository
    {
        public IEnumerable<Actor> GetActorsByIds(IEnumerable<int> actorsIds)
        {
            var result = new List<Actor>();

            foreach (var actorsId in actorsIds)
            {
                foreach (var actor in StaticDB.InMemoryDb.Actors)
                {
                    if (actor.Id == actorsId)
                    {
                        result.Add(actor);
                    }
                }
            }

            return result;

        }


        public Actor? GetById(int id)
        {
            return StaticDB.InMemoryDb.Actors.
                FirstOrDefault(x => x.Id == id);
        }
    }
}
