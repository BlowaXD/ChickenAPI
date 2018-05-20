using ChickenAPI.Enums.Game.Portals;

namespace ChickenAPI.Game.Maps
{
    public interface IPortal
    {
        /// <summary>
        ///     Portal Type
        /// </summary>
        PortalType Type { get; }

        bool IsAvailable { get; }

        short X { get; }
        short Y { get; }

        /// <summary>
        ///     Where the portal is placed
        /// </summary>
        IMapLayer Origin { get; }

        /// <summary>
        ///     Where the portal teleport you
        /// </summary>
        IMapLayer Destination { get; }
    }
}