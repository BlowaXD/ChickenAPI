using System.Collections.Generic;
using System.Linq;
using ChickenAPI.Data.TransferObjects;
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
                //NOT ENOUGH SPACE
                return;
            }
            subinv.Append(new ItemInstanceDto());
        }

        private int GetFirstFreeSlot(ItemInstanceDto[] subinventory)
        {
            for (var i = 0; i < subinventory.Length; i++)
            {
                var item = subinventory.First(x => x.Slot == i);

                if (item == null)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
