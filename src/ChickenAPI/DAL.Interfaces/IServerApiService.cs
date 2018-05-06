using System;
using System.Collections.Generic;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface IServerApiService
    {
        /// <summary>
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true if the ServerApi failed to register</returns>
        bool RegisterServer(WorldServerDto dto);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        void UnregisterServer(Guid id);

        IEnumerable<WorldServerDto> GetServers();
    }
}