using ChickenAPI.Dtos;
using ChickenAPI.Player.Enums;

namespace ChickenAPI.DAL.Interfaces
{
    public interface IAuthService
    {
        AuthenticationState CanLogin(string username, string password);
        PlayerSessionDto GetSession(string username, string password);
    }
}