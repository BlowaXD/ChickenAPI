using System;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface ISessionService
    {
        void RegisterSession(PlayerSessionDto dto);
        void UpdateSession(PlayerSessionDto dto);

        PlayerSessionDto GetByName(string name);
        PlayerSessionDto GetById(int id);

        void UnregisterSession(PlayerSessionDto dto);
        void UnregisterSession(int sessionId);
        void UnregisterSessions(Guid serverId);
    }
}