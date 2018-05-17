using System.Collections.Generic;
using ChickenAPI.ECS.Contexts;

namespace ChickenAPI.Game.Maps
{
    public interface IMap : IEntityManager
    {
        short Id { get; set; }

        /// <summary>
        /// This layer is the base map where everyone will be by default
        /// </summary>
        IMapLayer BaseLayer { get; }

        /// <summary>
        /// Different layers of the Map
        /// </summary>
        HashSet<IMapLayer> Layers { get; }

        /// <summary>
        /// All the portals that are in the map by base
        /// </summary>
        HashSet<IPortal> Portals { get; }

        /// <summary>
        /// Map Width
        /// </summary>
        short Width { get; }

        /// <summary>
        /// Map Height
        /// </summary>
        short Height { get; }

        /// <summary>
        /// Get the Map Grid
        /// </summary>
        byte[] Grid { get; }

        /// <summary>
        /// Get if the map is walkable
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        bool IsWalkable(int x, int y);
    }
}