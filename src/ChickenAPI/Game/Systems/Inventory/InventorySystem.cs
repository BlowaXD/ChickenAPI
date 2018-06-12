using System;
using System.Linq;
using ChickenAPI.Data.TransferObjects.Item;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Enums.Game.Items;
using ChickenAPI.Game.Components;

namespace ChickenAPI.Game.Systems.Inventory
{
    public class InventorySystem : NotifiableSystemBase
    {
        private const short MAX_AMOUNT_PER_SLOT = 999;

        public InventorySystem(IEntityManager em) : base(em)
        {

        }

        public override void Execute(IEntity entity, SystemEventArgs e)
        {
            var inventory = entity.GetComponent<InventoryComponent>();

            switch (e)
            {
                case InventoryAddItemEventArgs addItemEventArgs:
                    AddItem(inventory, addItemEventArgs);
                    break;

                case InventoryDropItemEventArgs dropItemEventArgs:
                    DropItem(inventory, dropItemEventArgs);
                    break;

                case InventoryDestroyItemEventArgs destroyItemEventArgs:
                    DestroyItem(inventory, destroyItemEventArgs);
                    break;
            }
        }

        private void AddItem(InventoryComponent inv, InventoryAddItemEventArgs args)
        {
            var subinv = GetSubInvFromItemInstance(inv, args.Item);

            var slot = GetFirstFreeSlot(subinv);

            if (slot == -1)
            {
                //Not enough space
                return;
            }

            subinv.Append(new ItemInstanceDto { Item = args.Item, Amount = args.Amount, Slot = slot});
        }

        private void DropItem(InventoryComponent inv, InventoryDropItemEventArgs args)
        {
            if (!args.ItemInstance.Item.IsDroppable)
            {
                //Item is not droppable
                return;
            }

            var subinv = GetSubInvFromItemInstance(inv, args.ItemInstance.Item);

            var itemIndex = Array.FindIndex(subinv, x => x.Slot == args.ItemInstance.Slot);

            subinv[itemIndex] = null;
        }

        private void DestroyItem(InventoryComponent inv, InventoryDestroyItemEventArgs args)
        {
            var subinv = GetSubInvFromItemInstance(inv, args.ItemInstance.Item);

            var itemIndex = Array.FindIndex(subinv, x => x.Slot == args.ItemInstance.Slot);

            subinv[itemIndex] = null;
        }

        private short GetFirstFreeSlot(ItemInstanceDto[] subinventory)
        {
            for (var i = 0; i < subinventory.Length; i++)
            {
                var item = subinventory.First(x => x.Slot == i);

                if (item == null)
                {
                    return (short)i;
                }
            }
            return -1;
        }

        private ItemInstanceDto[] GetSubInvFromItemInstance(InventoryComponent inv, ItemDto item)
        {
            switch (item.Type)
            {
                case InventoryType.Wear:
                    return inv.Wear;
                case InventoryType.Equipment:
                    return inv.Equipment;
                case InventoryType.Main:
                    return inv.Main;
                case InventoryType.Etc:
                    return inv.Etc;
                default:
                    return null;
            }
        }
    }
}
