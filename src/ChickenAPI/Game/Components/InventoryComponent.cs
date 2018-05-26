using ChickenAPI.Data.TransferObjects.Item;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Items;

namespace ChickenAPI.Game.Components
{
    public class InventoryComponent : IComponent
    {
        public const byte INVENTORY_SIZE = 196;

        public const short MAX_ITEMS_PER_SLOT = 999;

        public InventoryComponent(IEntity entity)
        {
            ItemInstances = new ItemInstanceDto[INVENTORY_SIZE];
            Entity = entity;
        }

        public ItemInstanceDto[] ItemInstances { get; set; }

        public IEntity Entity { get; }
    }
}