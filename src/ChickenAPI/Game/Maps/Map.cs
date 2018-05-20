using System.Collections.Generic;

namespace ChickenAPI.Game.Maps
{
    public class Map : IMap
    {
        public Map(short id, byte[] grid, short width, short height)
        {
            Id = id;
            Grid = grid;
            Width = width;
            Height = height;
        }

        public short Id { get; set; }

        public IMapLayer BaseLayer { get; }

        public HashSet<IMapLayer> Layers { get; }

        public HashSet<IPortal> Portals { get; }

        public short Width { get; }

        public short Height { get; }

        public byte[] Grid { get; }

        public bool IsWalkable(short x, short y)
        {
            byte value = Grid[x + Width * y];
            return value == 0 || value == 2 || value >= 16 && value <= 19;
        }
    }
}
