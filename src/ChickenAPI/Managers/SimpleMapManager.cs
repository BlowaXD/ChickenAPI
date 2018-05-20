using System;
using System.Collections.Generic;
using Autofac;
using ChickenAPI.Data.AccessLayer;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Game.Maps;
using ChickenAPI.Game.Network;
using ChickenAPI.Utils;

namespace ChickenAPI.Managers
{
    public class SimpleMapManager : IMapManager
    {
        private readonly Dictionary<long, IMap> _maps = new Dictionary<long, IMap>();
        private readonly Dictionary<Guid, IMapLayer> _mapLayersById = new Dictionary<Guid, IMapLayer>();

        public IReadOnlyDictionary<long, IMap> Maps => _maps;
        public void ChangeMap(IPlayerEntity player, long mapId)
        {
            ChangeMapLayer(player, _maps[mapId].BaseLayer);
        }

        public void ChangeMapLayer(IPlayerEntity player, Guid mapLayerId)
        {
            ChangeMapLayer(player, _mapLayersById[mapLayerId]);
        }

        public void ChangeMapLayer(IPlayerEntity player, IMapLayer layer)
        {
            throw new NotImplementedException();
        }


        public IMapLayer GetBaseMapLayer(long mapId)
        {
            return GetBaseMapLayer(_maps[mapId]);
        }

        public IMapLayer GetBaseMapLayer(IMap map)
        {
            return map.BaseLayer;
        }
    }
}