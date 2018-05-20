using System;
using System.Collections.Generic;
using ChickenAPI.Game.Maps;
using ChickenAPI.Game.Network;

namespace ChickenAPI.Managers
{
    public interface IMapManager
    {
        IReadOnlyDictionary<long, IMap> Maps { get; }

        void ChangeMapLayer(ISession session, Guid mapLayerId);
        void ChangeMapLayer(ISession session, IMapLayer layer);

        IMapLayer GetBaseMapLayer(long mapId);
        IMapLayer GetBaseMapLayer(IMap map);

        void Initialize();
    }
}