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

        int X { get; }
        int Y { get; }

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