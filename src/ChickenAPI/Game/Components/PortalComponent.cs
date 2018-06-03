using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Portals;
using ChickenAPI.Game.Maps;

namespace ChickenAPI.Game.Components
{
    public class PortalComponent : IComponent
    {
        public PortalComponent(IEntity entity)
        {
            Entity = entity;
        }

        public IEntity Entity { get; }

        public long PortalId { get; set; }

        public PortalType Type { get; set; }

        public IMapLayer DestinationMapLayer { get; set; }

        public short DestinationX { get; set; }
        public short DestinationY { get; set; }

        public short SourceX { get; set; }
        public short SourceY { get; set; }
        public bool IsDisabled { get; set; }
    }
}