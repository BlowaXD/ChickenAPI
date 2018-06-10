using System;
using System.Collections.Generic;
using ChickenAPI.Data.TransferObjects.Map;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.Game.Maps
{
    public class SimpleMap : EntityManagerBase, IMap
    {
        private IMapLayer _baseMapLayer;
        private readonly MapDto _map;
        private readonly IEnumerable<MapNpcMonsterDto> _monsters;

        public SimpleMap((MapDto, IEnumerable<MapNpcMonsterDto>) dto)
        {
            _map = dto.Item1;
            _monsters = dto.Item2;
            _baseMapLayer = new SimpleMapLayer(this, _monsters);
            Layers = new HashSet<IMapLayer>();
            Portals = new HashSet<PortalDto>();
        }

        public long Id => _map.Id;
        public int MusicId => _map.Music;

        public IMapLayer BaseLayer => _baseMapLayer ?? (_baseMapLayer = new SimpleMapLayer(this, _monsters));
        public HashSet<IMapLayer> Layers { get; }
        public HashSet<PortalDto> Portals { get; }
        public short Width => _map.Width;
        public short Height => _map.Height;
        public byte[] Grid => _map.Grid;

        public bool IsWalkable(short x, short y)
        {
            try
            {
                byte gridCell = Grid[x + y * Width];
                return gridCell == 0 || gridCell == 2 || gridCell >= 16 && gridCell <= 19;
            }
            catch (Exception)
            {
                Log.Warn($"[IS_WALKABLE] {Id}: {x} {y}");
                return false;
            }
        }
    }
}