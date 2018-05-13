using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.Game.Components
{
    public class InventoryComponent : IComponent
    {
        public InventoryComponent(IEntity entity)
        {
            Entity = entity;
        }

        public IEntity Entity { get; }
    }
}