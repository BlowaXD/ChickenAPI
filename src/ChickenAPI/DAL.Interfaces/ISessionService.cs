using System;
using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface ISessionService
    {
        void RegisterSession(PlayerSessionDto dto);
        void UpdateSession(PlayerSessionDto dto);

        PlayerSessionDto GetByName(string name);
        PlayerSessionDto GetById(int id);

        void UnregisterSession(int sessionId);
        void UnregisterSessions(Guid serverId);
    }
}