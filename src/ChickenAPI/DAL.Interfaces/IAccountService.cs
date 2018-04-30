using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface IAccountService : IMappedRepository<AccountDto>
    {
        AccountDto GetByName(string name);
    }
}