using System.Collections.Generic;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;

namespace ChickenAPI.Game.Maps
{
    public class SimpleMap : EntityManagerBase, IMap
    {
        public SimpleMap(long mapId)
        {
            ParentEntityManager = null;
        }

        public short Id { get; set; }
        public IMapLayer BaseLayer { get; }
        public HashSet<IMapLayer> Layers { get; }
        public HashSet<IPortal> Portals { get; }
        public short Width { get; }
        public short Height { get; }
        public byte[] Grid { get; }
        public bool IsWalkable(int x, int y) => throw new System.NotImplementedException();
    }
}