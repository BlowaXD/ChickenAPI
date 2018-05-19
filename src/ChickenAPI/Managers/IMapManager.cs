using System;
using System.Collections.Generic;
using ChickenAPI.Game.Maps;
using ChickenAPI.Game.Network;

namespace ChickenAPI.Managers
{
    public interface IMapManager
    {
        IDictionary<short, IMap> Maps { get; set; }

        void ChangeMapLayer(ISession session, Guid mapLayerId);
        void ChangeMapLayer(ISession session, IMapLayer layer);

        IMapLayer GetBaseMapLayer(short mapId);
        IMapLayer GetBaseMapLayer(IMap map);
        IMapLayer GenerateMapLayer(IMap map);
    }
}