using System.Collections.Generic;
using ChickenAPI.Game.Entities;
using ChickenAPI.Session;

namespace ChickenAPI.Game.Maps
{
    public interface IMap
    {
        HashSet<IMapLayer> Layers { get; }
        HashSet<IPortal> Portals { get; }

        int Width { get; }
        int Height { get; }

        int[] Grid { get; }

        bool IsWalkable(int x, int y);
    }
}