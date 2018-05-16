using System;
using System.Collections.Generic;
using ChickenAPI.Game.Maps;
using ChickenAPI.Game.Network;

namespace ChickenAPI.Managers
{
    public class MapManager : IMapManager
    {

        public IDictionary<short, IMap> Maps { get; set; }

        public void ChangeMapLayer(ISession session, Guid mapLayerId)
        {
            throw new NotImplementedException();
        }

        public void ChangeMapLayer(ISession session, IMapLayer layer)
        {
            throw new NotImplementedException();
        }

        public IMapLayer GetBaseMapLayer(short mapId)
        {
            return Maps[mapId]?.BaseLayer;
        }

        public IMapLayer GetBaseMapLayer(IMap map)
        {
            return map?.BaseLayer;
        }

        public IMapLayer GenerateMapLayer(IMap map)
        {
            var layer = new MapLayer(map);
            map.Layers.Add(layer);
            return layer;
        }
    }
}
