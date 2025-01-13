using MovieStore.Models.DTO;
using MovieStore.Models.DTO;

namespace MovieStore.BL.Interfaces
{
    public interface IActorService
    {
        Actor? GetActorById(int id);
    }
}