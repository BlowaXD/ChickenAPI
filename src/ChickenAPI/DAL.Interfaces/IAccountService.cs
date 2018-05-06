using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface IAccountService : IMappedRepository<AccountDto>
    {
        /// <summary>
        /// Will return the AccountDto associated to name given as parameter
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        AccountDto GetByName(string name);
    }
}