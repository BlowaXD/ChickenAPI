using System;
using System.Collections.Generic;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.Game.Maps
{
    public class SimpleMap : EntityManagerBase, IMap
    {
        private IMapLayer _baseMapLayer;
        private readonly IEnumerable<MapNpcMonsterDto> _monsters;
        public SimpleMap((MapDto, IEnumerable<MapNpcMonsterDto>) dto)
        {
            MapDto map = dto.Item1;
            _monsters = dto.Item2;
            Id = map.Id;
            MusicId = map.Music;
            _baseMapLayer = new SimpleMapLayer(this, _monsters);
            Layers = new HashSet<IMapLayer>();
            Portals = new HashSet<IPortal>();
            Width = map.Width;
            Height = map.Height;
            Grid = map.Grid;
        }

        public long Id { get; }
        public int MusicId { get; }

        public IMapLayer BaseLayer
        {
            get => _baseMapLayer ?? (_baseMapLayer = new SimpleMapLayer(this, _monsters));
        }
        public HashSet<IMapLayer> Layers { get; }
        public HashSet<IPortal> Portals { get; }
        public short Width { get; }
        public short Height { get; }
        public byte[] Grid { get; }

        public bool IsWalkable(short x, short y)
        {
            try
            {
                byte gridCell = Grid[x + y * Width];
                return gridCell == 0 || gridCell == 2 || gridCell >= 16 && gridCell <= 19;
            }
            catch (Exception)
            {
                Log.Warn($"[IS_WALKABLE]");
                return false;
            }
        }
    }
}