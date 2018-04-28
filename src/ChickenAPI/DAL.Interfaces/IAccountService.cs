using ChickenAPI.Dtos;

namespace ChickenAPI.Accounts
{
    public interface IAccountService
    {
        AccountDto GetByName(string name);
        AccountDto GetById(ulong id);
    }
}