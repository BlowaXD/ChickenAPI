using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface ISessionService : IMappedRepository<PlayerSessionDto>
    {
    }
}