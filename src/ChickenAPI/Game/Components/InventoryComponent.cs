using ChickenAPI.Data.TransferObjects.Item;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Items;

namespace ChickenAPI.Game.Components
{
    public class InventoryComponent : IComponent
    {
        public const byte InventorySize = 196;

        public InventoryComponent(IEntity entity)
        {
            ItemInstances = new ItemInstanceDto[InventorySize];
            Entity = entity;
        }

        public ItemInstanceDto[] ItemInstances { get; set; }

        public IEntity Entity { get; }
    }
}