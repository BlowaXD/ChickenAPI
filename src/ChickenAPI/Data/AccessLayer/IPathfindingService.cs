using System.Collections.Generic;
using ChickenAPI.Game.Maps;
using ChickenAPI.Utils;

namespace ChickenAPI.Data.AccessLayer
{
    public interface IPathfindingService
    {
        Queue<Position<short>> GetPath(Position<short> origin, Position<short> dest, IMap map);
    }
}