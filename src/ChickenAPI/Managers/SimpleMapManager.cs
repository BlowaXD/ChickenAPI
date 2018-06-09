using System;
using System.Collections.Generic;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.Data.TransferObjects.Map;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Game.Maps;

namespace ChickenAPI.Managers
{
    public class SimpleMapManager : IMapManager
    {
        public SimpleMapManager(IEnumerable<(MapDto, IEnumerable<MapNpcMonsterDto>)> dtos)
        {
            foreach ((MapDto, IEnumerable<MapNpcMonsterDto>) dto in dtos)
            {
                _maps[dto.Item1.Id] = new SimpleMap(dto);
            }
        }

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
            player.TransferEntity(layer);
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