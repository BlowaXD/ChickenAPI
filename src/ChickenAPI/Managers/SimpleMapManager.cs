using System;
using System.Collections.Generic;
using Autofac;
using ChickenAPI.Data.AccessLayer;
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

        public void ChangeMapLayer(ISession session, Guid mapLayerId)
        {
        }

        public void ChangeMapLayer(ISession session, IMapLayer layer)
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

        public void Initialize()
        {
            Container.Instance.Resolve<IMapService>();
        }
    }
}