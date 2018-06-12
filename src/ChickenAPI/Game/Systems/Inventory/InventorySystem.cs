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
            ItemInstanceDto[] subinv;

            switch (args.Item.Type)
            {
                case InventoryType.Wear:
                    subinv = inv.Wear;
                    break;
                case InventoryType.Equipment:
                    subinv = inv.Equipment;
                    break;
                case InventoryType.Main:
                    subinv = inv.Main;
                    break;
                case InventoryType.Etc:
                    subinv = inv.Etc;
                    break;
                default:
                    return;
            }

            var slot = GetFirstFreeSlot(subinv);

            if (slot == -1)
            {
                //Not enough space
                return;
            }
            subinv.Append(new ItemInstanceDto() { Item = args.Item, Amount = args.Amount, Slot = slot});
        }

        private void DropItem(InventoryComponent inv, InventoryDropItemEventArgs args)
        {
            if (!args.ItemInstance.Item.IsDroppable)
            {
                //Item is not droppable
                return;
            }

            ItemInstanceDto[] subinv;

            switch (args.ItemInstance.Item.Type)
            {
                case InventoryType.Wear:
                    subinv = inv.Wear;
                    break;
                case InventoryType.Equipment:
                    subinv = inv.Equipment;
                    break;
                case InventoryType.Main:
                    subinv = inv.Main;
                    break;
                case InventoryType.Etc:
                    subinv = inv.Etc;
                    break;
                default:
                    return;
            }

            var itemIndex = Array.FindIndex(subinv, x => x.Slot == args.ItemInstance.Slot);

            subinv[itemIndex] = null;
        }

        private void DestroyItem(InventoryComponent inv, InventoryDestroyItemEventArgs args)
        {
            ItemInstanceDto[] subinv;

            switch (args.ItemInstance.Item.Type)
            {
                case InventoryType.Wear:
                    subinv = inv.Wear;
                    break;
                case InventoryType.Equipment:
                    subinv = inv.Equipment;
                    break;
                case InventoryType.Main:
                    subinv = inv.Main;
                    break;
                case InventoryType.Etc:
                    subinv = inv.Etc;
                    break;
                default:
                    return;
            }

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
    }
}
