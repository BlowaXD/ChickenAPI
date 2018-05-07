using ChickenAPI.Enums.Game.Portals;

namespace ChickenAPI.Game.Maps
{
    public interface IPortal
    {
        PortalType Type { get; }

        bool IsAvailable { get; }

        int X { get; }
        int Y { get; }
    }
}