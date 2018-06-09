using ChickenAPI.Data.TransferObjects;
using ChickenAPI.Data.TransferObjects.Item;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.Game.Components
{
    public class InventoryComponent : IComponent
    {
        public InventoryComponent(IEntity entity) => Entity = entity;

        public ItemInstanceDto ItemInstances { get; set; }

        public IEntity Entity { get; }
    }
}