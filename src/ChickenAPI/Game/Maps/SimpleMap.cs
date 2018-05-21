using System;
using System.Collections.Generic;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Utils;

namespace ChickenAPI.Game.Maps
{
    public class SimpleMap : EntityManagerBase, IMap
    {
        public SimpleMap(MapDto map)
        {
            Id = map.Id;
            MusicId = map.Music;
            BaseLayer = new SimpleMapLayer(this);
            Layers = new HashSet<IMapLayer>();
            Portals = new HashSet<IPortal>();
            Width = map.Width;
            Height = map.Height;
            Grid = map.Grid;
        }

        public long Id { get; }
        public int MusicId { get; }
        public IMapLayer BaseLayer { get; }
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